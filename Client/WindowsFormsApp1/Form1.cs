using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		private Thread receiveThread;
		private Socket socket;
		private bool propellerflag = false;
		private bool Autoflag = false; // 자동제어를 조절 하기 위한 플래그
		private bool ACflag = false;
		private bool Lightflag = false;
		private bool Heflag = false;
		private bool Winflag = false;
		private bool Humflag = false;
		private short 온도;
		private short 습도;
		private short 조도;

		public Form1()
		{
			InitializeComponent();
		}

		// 수신 처리
		private void Receive()
		{
			while (true)
			{
				byte[] recevieBuffer = new byte[6];
				short[] recev = new short[3];

				// 연결된 서버가 보낸 데이터 수신
				if (socket.Receive(recevieBuffer, recevieBuffer.Length, SocketFlags.None) >= 6)
				{
					for (int i = 0; i < 3; i++)
					{ // 서버로부터 전송받은 byte값을 short값으로 변환
						recev[i] = BitConverter.ToInt16(recevieBuffer, (i * 2));
					}

					chart1.Series[0].Points.Clear();
					chart2.Series[0].Points.Clear();
					chart3.Series[0].Points.Clear();
					chart1.Series[0].Points.AddXY("온도", recev[0]);
					chart2.Series[0].Points.AddXY("습도", recev[1]);
					chart3.Series[0].Points.AddXY("조도", recev[2]);
				}

				/*  자동 제어 조건 Autoflag = false;
					클라이언트로 부터 서버로 데이터 값을 보낼때 byte단위로 보내기 위해서 BitConverter를 사용함
					단, BitConverter를 사용할 경우 low비트와 high비트 위치가 바뀜에 주의
				*/
				// 조명제어
				byte[] on = BitConverter.GetBytes(1023);
				if (Autoflag == false && Lightflag == false && recev[2] <= 조도) // 조도가 500 이하이고 조명이 켜지지않은 경우 조명On
				{
					socket.Send(new byte[] { 1, on[0], on[1] });
					Lightflag = true;
					LightLabel.Text = "조명: On";
					hScrollBar1.Value = 1032;
				}
				else if (Autoflag == false && Lightflag == true && recev[2] > 조도) // 조도가 500 미만이고 조명이 켜져있을 경우 조명Off
				{
					socket.Send(new byte[] { 1, 0, 0 });
					Lightflag = false;
					LightLabel.Text = "조명: Off";
					hScrollBar1.Value = 0;
				}

				// 가습기 제어
				if (Autoflag == false && Humflag == false && recev[1] < 습도) // 습도가 일정수준 미만이고 가습기가 꺼져있을경우 가습기 On
				{
					socket.Send(new byte[] { 2, on[0], on[1] });
					Humflag = true;
					HumL.Text = "가습기 : On";
					HumB.Text = "켜짐";
				}
				else if (Autoflag == false && Humflag == true && recev[1] >= 습도) // 습도가 일정수준 이상이고 가습기가 켜져있을 경우 가습기Off
				{
					socket.Send(new byte[] { 2, 0, 0 });
					Humflag = false;
					HumL.Text = "가습기 : Off";
					HumB.Text = "꺼짐";
				}

				// 선풍기 제어
				if (Autoflag == false && propellerflag == false && recev[0] >= 온도) // 온도가 지정 이상일 경우 선풍기 On
				{
					socket.Send(new byte[] { 3, on[0], on[1] });
					propellerflag = true;
					Prop.Text = "선풍기 : On";
					ProB.Text = "켜짐";
				}
				else if (Autoflag == false && propellerflag == true && recev[0] < 온도) // 온도가 지정 미만일 경우 선풍기 Off
				{
					socket.Send(new byte[] { 3, 0, 0 });
					propellerflag = false;
					Prop.Text = "선풍기 : Off";
					ProB.Text = "꺼짐";
				}

				// 냉방기
				if (Autoflag == false && ACflag == false && recev[0] >= 온도) // 온도가 지정 수준 이상이면 냉방
				{
					socket.Send(new byte[] { 4, on[0], on[1] });
					ACflag = true;
					Ac.Text = "냉방기 : On";
					hScrollBar2.Value = 1032;
				}
				else if (Autoflag == false && ACflag == true && recev[0] < 온도) // 지정 수준 미달이면 냉방Off
				{
					socket.Send(new byte[] { 4, 0, 0 });
					ACflag = false;
					Ac.Text = "냉방기 : Off";
					hScrollBar2.Value = 0;
				}

				// 난방기
				if (Autoflag == false && Heflag == false && recev[0] < 온도) // 지정 수준 미달이면 난방On
				{
					socket.Send(new byte[] { 5, on[0], on[1] });
					Heflag = true;
					He.Text = "난방기 : On";
					hScrollBar3.Value = 1032;
				}
				else if (Autoflag == false && Heflag == true && recev[0] >= 온도) // 지정 수준 이상이면 난방Off
				{
					socket.Send(new byte[] { 5, 0, 0 });
					Heflag = false;
					He.Text = "난방기 : Off";
					hScrollBar3.Value = 0;
				}

				// 창문
				if (Autoflag == false && Winflag == false && recev[0] >= 온도) // 온도가 지정 수준 이상이면 Open
				{
					socket.Send(new byte[] { 6, on[0], on[1] });
					Winflag = true;
					WindowL.Text = "창문 : 열림";
					WindowB.Text = "열림";
				}
				else if (Autoflag == false && Winflag == true && recev[0] < 온도) // 지정 수준 미달이면 close
				{
					socket.Send(new byte[] { 6, 0, 0 });
					Winflag = false;
					WindowL.Text = "창문 : 닫힘";
					WindowB.Text = "닫힘";
				}
			}
		}

		// 서버에 접속하는 부분
		private void button1_Click(object sender, EventArgs e)
		{
			// 서버 연결하기
			IPAddress ipaddress = IPAddress.Parse(textBox2.Text);
			IPEndPoint endPoint = new IPEndPoint(ipaddress, int.Parse(textBox3.Text));

			// 연결 소켓 생성
			socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

			// 연결하기
			socket.Connect(endPoint);
			
			// Receive 스레드 처리(서버 <-> 클라이언트)
			receiveThread = new Thread(new ThreadStart(Receive));
			receiveThread.IsBackground = true;
			receiveThread.Start();
		}
		
		private void Form1_Load(object sender, EventArgs e)
		{
			온도 = 25;
			습도 = 50;
			조도 = 200;
			textBox2.Text = "172.17.33.173";
			textBox3.Text = "8000";
			temp_text.Text = 온도.ToString();
			hum_text.Text = 습도.ToString();
			LightText.Text = 조도.ToString();
		}

		// 수동 조작시 오토를 끄기위한 함수
		private void ChangeB()
		{
			Autoflag = true;
			SetB.Text = "Off";
		}

		// 오토 조정 버튼
		private void SetB_Click(object sender, EventArgs e)
		{
			if(Autoflag == true)
			{
				Autoflag = false;
				SetB.Text = "On";
			}
			else
			{
				Autoflag = true;
				SetB.Text = "Off";
			}
			
		}

		// 창문 제어 버튼
		private void WindowB_Click(object sender, EventArgs e)
		{
			ChangeB();
			if (Autoflag)
			{
				byte[] temp = BitConverter.GetBytes(1023);
				if (Winflag)
				{
					socket.Send(new byte[] { 6, temp[0],  temp[1]});
					WindowL.Text = "창문 : 열림";
					WindowB.Text = "열림";
					Winflag = false;
				}
				else
				{
					socket.Send(new byte[] { 6, 0, 0 });
					WindowL.Text = "창문 : 닫힘";
					WindowB.Text = "닫힘";
					Winflag = true;
				}
			}
		}

		// 가습기 제어 버튼
		private void HumB_Click(object sender, EventArgs e)
		{
			ChangeB();
			if (Autoflag)
			{
				byte[] temp;
				if (Humflag)
				{
					temp = BitConverter.GetBytes(1023);
					socket.Send(new byte[] { 2, temp[0], temp[1] });
					HumL.Text = "가습기 : On";
					HumB.Text = "켜짐";
					Humflag = false;
				}
				else
				{
					socket.Send(new byte[] { 2, 0, 0 });
					HumL.Text = "가습기 : Off";
					HumB.Text = "꺼짐";
					Humflag = true;
				}
			}
		}

		//선풍기 제어 버튼
		private void ProB_Click(object sender, EventArgs e)
		{
			ChangeB();
			if (Autoflag)
			{
				if (propellerflag)
				{
					byte[] temp = BitConverter.GetBytes(1023);
					socket.Send(new byte[] { 3, temp[0], temp[1] });
					Prop.Text = "선풍기 : On";
					ProB.Text = "켜짐";
					propellerflag = false;
				}
				else
				{
					socket.Send(new byte[] { 3, 0, 0 });
					Prop.Text = "선풍기 : Off";
					ProB.Text = "꺼짐";
					propellerflag = true;
				}
			}
		}

		// 조명 밝기 조정 스크롤
		private void hScrollBar1_MouseCaptureChanged(object sender, EventArgs e)
		{
			int light = hScrollBar1.Value;
			ChangeB();
			if (Autoflag)
			{
				byte[] temp = BitConverter.GetBytes(light);
				socket.Send(new byte[] { 1, temp[0], temp[1] });
				if (light != 0)
				{
					LightLabel.Text = "조명 : On";
				}
				else
				{
					LightLabel.Text = "조명 : Off";
				}
			}
		}

		// 냉방기 수동조절
		private void hScrollBar2_MouseCaptureChanged(object sender, EventArgs e)
		{
			int tempur = hScrollBar2.Value;
			ChangeB();
			if (Autoflag)
			{
				byte[] temp = BitConverter.GetBytes(tempur);
				socket.Send(new byte[] { 4, temp[0], temp[1] });
				if (tempur != 0)
				{
					Ac.Text = "냉방기 : On";
				}
				else
				{
					Ac.Text = "냉방기 : Off";
				}
			}
		}

		// 난방기 수동조절
		private void hScrollBar3_MouseCaptureChanged(object sender, EventArgs e)
		{
			int Hum = hScrollBar3.Value;
			ChangeB();
			if (Autoflag)
			{
				byte[] temp = BitConverter.GetBytes(Hum);
				socket.Send(new byte[] { 5, temp[0], temp[1] });
				if (Hum != 0)
				{
					He.Text = "난방기 : On";
				}
				else
				{
					He.Text = "난방기 : Off";
				}
			}
		}

		//적용버튼 클릭
		private void resetb_Click(object sender, EventArgs e)
		{
			온도 = Convert.ToInt16(temp_text.Text);
			습도 = Convert.ToInt16(hum_text.Text);
			조도 = Convert.ToInt16(LightText.Text);
		}
	}
}
