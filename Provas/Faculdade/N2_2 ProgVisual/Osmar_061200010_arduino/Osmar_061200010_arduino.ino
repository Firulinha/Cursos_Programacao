#define POT1 0
#define POT2 1
#define POT3 2
#define POT4 3
#define L1 13

int AN0;
int AN1;
int AN2;
int AN3;
String Rxdata;
 
void ConfigPlaca()
{
  pinMode(POT1, INPUT);
  pinMode(POT2, INPUT);
  pinMode(POT3, INPUT);
  pinMode(POT4, INPUT);
  pinMode(L1, OUTPUT);
  Serial.begin(9600);
}

void LeituraSerial()
{
  AN0 = analogRead(POT1);
  AN1 = analogRead(POT2);
  AN2 = analogRead(POT3);
  AN3 = analogRead(POT4);
  Serial.print(AN0);Serial.print(":");
  Serial.print(AN1);Serial.print(":");
  Serial.print(AN2);Serial.print(":");
  Serial.println(AN3);
  delay(100);
  
  if(Serial.available() > 0)
  {
    Rxdata = Serial.readStringUntil('\r'); 
    if(Rxdata.indexOf("[EN]") != -1)
   {
    digitalWrite(L1,1);
   }
   if(Rxdata.indexOf("[DN]") != -1)
   {
    digitalWrite(L1,0);
   }
  }
}


void setup()
{
  ConfigPlaca();
}

void loop()
{
  LeituraSerial();
}
