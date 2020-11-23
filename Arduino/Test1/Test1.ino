int bLed = 13;
int gLed = 12;
int yLed = 11;
//char myCol[10];
//char *inint_state = '0';

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600); //open the seial to connect with the UI
  //Set up the pins
  pinMode(bLed, OUTPUT); 
  pinMode(gLed, OUTPUT);
  pinMode(yLed, OUTPUT);

  //turn off all the leds
  digitalWrite(bLed,LOW);
  digitalWrite(gLed,LOW);
  digitalWrite(yLed,LOW);
}

void loop() {
  // put your main code here, to run repeatedly:
  int lf = 20;
  char c;
  //Serial.readBytesUntil(lf,myCol,1);
  c = Serial.read();
  if(c){
    switch(c){
      case '1':
        digitalWrite(bLed,HIGH);
        digitalWrite(gLed,HIGH);
        digitalWrite(yLed,HIGH);
        delay(500);
        break;
       case '2':
        digitalWrite(bLed,HIGH);
        digitalWrite(gLed,LOW);
        digitalWrite(yLed,LOW);
        delay(500);
        break;
       case '3':
        digitalWrite(bLed,LOW);
        digitalWrite(gLed,HIGH);
        digitalWrite(yLed,LOW);
        delay(500);
    }
    c = '0';
  }
  digitalWrite(bLed,LOW);
  digitalWrite(gLed,LOW);
  digitalWrite(yLed,LOW);
}
