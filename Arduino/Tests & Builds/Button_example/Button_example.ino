void setup() {
  pinMode(13,OUTPUT);
  pinMode(9,INPUT);
  digitalWrite(9,HIGH);
}

void loop(){
  
 if(digitalRead(9) == HIGH)
 {
   digitalWrite(13,LOW);
 }
 else
 {
   digitalWrite(13,HIGH);
 }
}
