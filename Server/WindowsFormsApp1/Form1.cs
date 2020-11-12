using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int port = 8000;
        private Thread listenThread;
        private Thread receiveThread;
        private Socket clientSocket;
        private const int sendBytesSize = 6;
        private const int incomingBytesSize = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void ShowMsg(string msg)
        {
            richTextBox1.AppendText(msg + '\n');
            richTextBox1.ScrollToCaret();
        }

        // 수신 처리
        private void Receive()
        {
            // 연결된 클라이언트가 보낸 데이터 수신을 쓰레드로 반복 수행
            while (true)
            {
                // 수신할 바이트 배열을 규약 크기에 맞춰 선언
                byte[] receiveBuffer = new byte[incomingBytesSize];

                // 정상적으로 수신됐을 경우
                if (clientSocket.Receive(receiveBuffer, receiveBuffer.Length, SocketFlags.None) > 0)
                {
                    // 수신 정보를 바이트로 디코딩 후 메시지 출력
                    ShowMsg("Recived client: 장치 = " + receiveBuffer[0].ToString() +
                        ", 제어 = " + BitConverter.ToInt16(receiveBuffer, 1).ToString());

                    // 시리얼 포트로 아두이노로 전송
                    serialPort1.Write(receiveBuffer, 0, receiveBuffer.Length);
                }
            }
        }

        private void Listen()
        {
            string localIP = "Not available, please check your network seetings!";
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    ShowMsg("Server IP: " + localIP);
                }
            }

            // 종단점
            IPAddress ipaddress = IPAddress.Parse(localIP);
            IPEndPoint endPoint = new IPEndPoint(ipaddress, port);

            // 소켓 생성
            Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // 바인드
            listenSocket.Bind(endPoint);

            // 준비
            listenSocket.Listen(10);

            // 수신 대기
            // 여기서 블럭이 걸려야 하지만 스레드로 따로 처리하기 때문에 다른 작업이 가능
            clientSocket = listenSocket.Accept();

            // Receive 스레드 호출
            receiveThread = new Thread(new ThreadStart(Receive));
            receiveThread.IsBackground = true;
            receiveThread.Start(); // Receive() 호출
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 폼이 로드되면 스레드 시작, 클라이언트에서 서버로 도착하는 
            listenThread = new Thread(new ThreadStart(Listen));
            listenThread.IsBackground = true;
            listenThread.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 폼이 닫힐 때 시리얼 포트도 닫기
            serialPort1.Close();
        }

        // 시리얼 포트 연결 버튼을 눌렀을 때 수행
        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = textBox1.Text;
            serialPort1.Open();
            serialPort1.DiscardInBuffer();  // 시리얼 포트 수신 버퍼 비우기
            ShowMsg(serialPort1.PortName + " opened");
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            // 수신 속도와 송신 속도 차이로 수신이 더 빨리 이루어진다
            if (serialPort1.BytesToRead >= sendBytesSize)  // 필요한 데이터가 모두 수신 됐을 때 수행
            {
                byte[] buffer = new byte[sendBytesSize];
                serialPort1.Read(buffer, 0, sendBytesSize);

                // 클라언트가 연결 됐을 때 수행
                if (clientSocket != null)
                {
                    clientSocket.Send(buffer);  // 클라이언트로 정보 전송
                }
            }
        }
    }
}
