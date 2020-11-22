int bLed = 13;
int gLed = 12;
int yLed = 11;
char myCol[20];

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600); //open the seial to connect with the UI
  //Set up the pins
  pinMode(bLed, OUTPUT); 
  pinMode(gLed, OUTPUT);
  pinMode(yLed, OUTPUT);

  //turn of all the leds
  digitalWrite(bLed,LOW);
  digitalWrite(gLed,LOW);
  digitalWrite(yLed,LOW);
}

void loop() {
  // put your main code here, to run repeatedly:
  int lf = 10;
  Serial.readBytesUntil(lf,myCol,1);
  if(strcmp(myCol, "chest") == 0){
    digitalWrite(bLed,HIGH);
    digitalWrite(gLed,HIGH);
    digitalWrite(yLed,HIGH);
    delay(500);
    digitalWrite(bLed,LOW);
    digitalWrite(gLed,LOW);
    digitalWrite(yLed,LOW);
  }

}
