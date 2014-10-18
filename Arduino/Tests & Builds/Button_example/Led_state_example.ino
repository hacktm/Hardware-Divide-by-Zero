//INCLUDES
#include <WString.h>

//CONSTANTS
#define RED 1
#define YELLOW 2
#define GREEN 3
#define SERIAL_BAUDRATE 9600
#define STX "\x02"
#define ETX "\x03"
#define RS "$"

//WARNING ERROR AND STATUS CODES
#define MSG_METHOD_SUCCESS 0
#define WRG_NO_SERIAL_DATA_AVAILABLE 250
#define ERR_SERIAL_IN_COMMAND_NOT_TERMINATED -1

//VARIABLE DECLARATION
int state;
int ledState;
unsigned long time;
unsigned long currentMillis;
unsigned long previousMillis=0;

void Initialise()
{
  state=0x00;
  ledState=LOW;
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

void Test_State()
{
  if(digitalRead(9) == LOW) // Work in progress
 {
   digitalWrite(12,HIGH); // Turn red ON and all other OFF 
   digitalWrite(11,LOW);
   digitalWrite(13,LOW);
   state |= RED;
   state &= RED;
 } 
 if(digitalRead(10) == LOW)
 {
   digitalWrite(11,HIGH); // Turn yellow ON and all other OFF
   digitalWrite(13,LOW);
   digitalWrite(12,LOW);
   state |= YELLOW;
   state &= YELLOW; 
 }
 if(digitalRead(8) == LOW) // Turn green ON and all other OFF
 {
   digitalWrite(13,HIGH);
   digitalWrite(11,LOW);
   digitalWrite(12,LOW);
   state |= GREEN;
   state &= GREEN;
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
  case RED :{wait(100,12);break;}
  case YELLOW :{wait(700,11);break;}
  case GREEN : {break;}
  }
}
void setup() 
{
 Initialise(); 
 Serial.begin(SERIAL_BAUDRATE);
}

void loop(){
  Test_State();
  Action_State(); 
}
