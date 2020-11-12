#include <DHT.h>
#include <LiquidCrystal_I2C.h>
#include <Servo.h>

DHT dht(12, DHT11);
LiquidCrystal_I2C lcd(0x27, 16, 2);
Servo myservo;

// 전송 정보 정의
const int sendBytesSize = 6;  // 전송 정보 크기

// 수신 정보 정의
const int incomingBytesSize = 3;  // 수신 정보 크기
byte incomingBytes[incomingBytesSize] = { 0 };  // 수신 정보 배열

// 환경 수치 정의
short temperature = 0,  // 온도
      humidity = 0,  // 습도
      illumination  = 0;  // 조도

// 장치 제어 값 정의
short lamp = 0,  // 조명
      humidifier = 0,  // 가습기
      fan = 0,  // 선풍기
      cooler = 0,  // 냉방기
      heater = 0,  // 난방기
      window = 0;  // 창문

void setup() {
  Serial.begin(9600);

  // 온/습도 센서 초기 설정
  dht.begin();

  // 조명(LED) 초기 설정
  pinMode(9, OUTPUT);

  // 가습기(LED) 초기 설정
  pinMode(10, OUTPUT);

  // 선풍기(Fan) 초기 설정
  pinMode(7, OUTPUT);
  pinMode(6, OUTPUT);

  // 냉/난방기(LCD) 초기 설정
  lcd.begin();
  lcd.print("Cooler = ");
  lcd.print(cooler);
  lcd.setCursor(0, 1);
  lcd.print("heater = ");
  lcd.print(heater);

  // 창문(Servo Motor) 초기 설정
  myservo.attach(13);
}

void loop() {
  // 조도 측정
  illumination = analogRead(0);

  // 온도 측정
  temperature = dht.readTemperature();

  // 습도 측정
  humidity = dht.readHumidity();

  // 송신 정보(환경 정보)
  byte sendBytes[sendBytesSize] = {  // 송신 배열 선언
    lowByte(temperature), highByte(temperature),  // 2바이트 온도 수치
    lowByte(humidity), highByte(humidity),  // 2바이트 습도 수치
    lowByte(illumination), highByte(illumination)  // 2바이트 조도 수치
  };
  Serial.write(sendBytes, sendBytesSize);

  // 수신 정보(제어 정보)
  if (Serial.available()) {
    Serial.readBytes(incomingBytes, incomingBytesSize);  // 수신 정보 읽기
    short controlValue = (short)incomingBytes[2] << 8 | (short)incomingBytes[1];  // 2 바이트 장치 제어 값 디코딩
    switch (incomingBytes[0]) {  // 장치 종류 선택 값
      case 1:  // 조명 제어
        lamp = controlValue;
        digitalWrite(9, lamp);
        break;
      case 2:  // 가습기 제어
        humidifier = controlValue;
        digitalWrite(10, humidifier);
        break;
      case 3:  // 선풍기 제어
        fan = controlValue;
        if (fan) {
          digitalWrite(7, HIGH);
          digitalWrite(6, LOW);
        } else {
          digitalWrite(7, LOW);
          digitalWrite(6, LOW);
        }
        break;
      case 4:  // 냉방기 제어
        cooler = controlValue;
        lcd.clear();
        lcd.print("Cooler = ");
        lcd.print(cooler);
        lcd.setCursor(0, 1);
        lcd.print("heater = ");
        lcd.print(heater);
        break;
      case 5:  // 난방기 제어
        heater = controlValue;
        lcd.clear();
        lcd.print("Cooler = ");
        lcd.print(cooler);
        lcd.setCursor(0, 1);
        lcd.print("heater = ");
        lcd.print(heater);
        break;
      case 6:  // 창문 제어
        window = controlValue;
        if (window) {
          myservo.write(170);
        } else {
          myservo.write(10);
        }
        break;
    }
  }

  delay(200);
}
