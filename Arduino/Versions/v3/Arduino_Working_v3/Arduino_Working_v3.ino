//INCLUDES
#include <WString.h>
#include <LiquidCrystal.h>

//CONSTANTS
#define RED 1
#define YELLOW 2
#define GREEN 3
#define SERIAL_BAUDRATE 9600

//VARIABLE DECLARATION
int state;
int ledState;
unsigned long time;
unsigned long currentMillis,currentMillisDisplay;
unsigned long previousMillis=0,previousMillisDisplay=0;
char data_Received;
int data;
bool set_Red;
bool set_Yellow;
bool set_Green;
bool idle;
bool finished;
bool progress;

//METHOD AND OBJECT DECLARATION
LiquidCrystal LCD(7, 6, 5, 4, 3, 2);

void Initialise()
{
  data=0;
  state=0x00;
  ledState=LOW;
  set_Red=false;
  set_Yellow=true;
  set_Green=false;
  idle=true;
  finished=false;
  progress=false;
  pinMode(11,OUTPUT);
  pinMode(12,OUTPUT);
  pinMode(13,OUTPUT);
  pinMode(8,INPUT);
  pinMode(9,INPUT);
  pinMode(10,INPUT);
  digitalWrite(8,HIGH);
  digitalWrite(9,HIGH);
  digitalWrite(10,HIGH);
}

void Serial_Read()
{
  if(Serial.available()>0)
  {
    data_Received=Serial.read();
    data=data_Received-48;
  }
}

void Display_Data(int interval)
{
  currentMillisDisplay = millis();
  if(currentMillisDisplay - previousMillisDisplay > interval)
  {
    if(finished)
    {
      LCD.clear();
      LCD.print("LED:Green");
      LCD.setCursor(0,1);
      LCD.print("Results on PC.");
      LCD.setCursor(0,0);
      finished=false;
    }
  if(idle)
    {
      LCD.clear();
      LCD.print("LED:Yellow");
      LCD.setCursor(0,1);
      LCD.print("Status idle.");
      LCD.setCursor(0,0);
      idle=false; 
    }
  if(progress)
    {
      LCD.clear();
      LCD.print("LED:Red");
      LCD.setCursor(0,1);
      LCD.print("In progress.");
      LCD.setCursor(0,0);
      progress=false;
    }
  } 
}

void State_Manager()
{
  if(state == RED && !set_Red)
  {
      idle=false;
      Serial.print(1);
      set_Red=true;
      set_Green=false;
  }  
  if((state == GREEN && !set_Green))
  {
    set_Red=false;
    Serial.println("");
    set_Green=true;
    data=0;
  }
}

void Test_State()
{
  if(digitalRead(9) == LOW || (data==1)) // Work in progress
 {
   digitalWrite(12,HIGH); // Turn red ON and all other OFF 
   digitalWrite(11,LOW);
   digitalWrite(13,LOW);
   state |= RED;
   state &= RED;
   progress=true;
   data=0;
   set_Red=false;
 } 
 if(digitalRead(10) == LOW || set_Yellow)
 {
   digitalWrite(11,HIGH); // Turn yellow ON and all other OFF
   digitalWrite(13,LOW);
   digitalWrite(12,LOW);
   state |= YELLOW;
   state &= YELLOW; 
   idle=true;
   set_Yellow=false;
 }
 if(digitalRead(8) == LOW || (data==2)) // Turn green ON and all other OFF
 {
   digitalWrite(13,HIGH);
   digitalWrite(11,LOW);
   digitalWrite(12,LOW);
   state |= GREEN;
   state &= GREEN;
   finished=true;
   delay(3000);
   data=0;
   finished=false;
   set_Yellow=true; 
 }
}
void wait(int interval,int pin)
{
  currentMillis = millis();
  if(currentMillis - previousMillis > interval) 
  {
    previousMillis = currentMillis; 
    if(ledState == LOW)
      ledState = HIGH;
    else
      ledState = LOW;
    digitalWrite(pin,ledState); 
  }
}
void Action_State()
{
  switch(state)
  {
  case RED :{wait(40,12);break;}
  case YELLOW :{wait(700,11);break;}
  case GREEN : {break;}
  }
}
void setup() 
{
 Initialise(); 
 LCD.begin(16,2);
 Serial.begin(SERIAL_BAUDRATE);
}

void loop(){
  Test_State();
  Action_State();
  State_Manager(); 
  Display_Data(500);
  Serial_Read();
}
