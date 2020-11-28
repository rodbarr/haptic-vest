int r_chest = 3;
int l_chest = 5;
int back = 6;
int conn = 13;
char code;
bool conection = false;

void setup(){
  //Open the serial channel for
  //connection with the UI
  Serial.begin(9600);
  //Set up the pins 
  pinMode(conn, OUTPUT);
  pinMode(r_chest,OUTPUT);
  pinMode(l_chest,OUTPUT);
  pinMode(back,OUTPUT);
  
  //Turn off the motors
  digitalWrite(r_chest,LOW);
  digitalWrite(l_chest,LOW);
  digitalWrite(back,LOW);
  digitalWrite(conn,LOW);
}

void loop(){
  //Check if there is input on the buffer
  if (Serial.available() > 0){
    //Read the code sent from the UI
    code = Serial.read();
    //Serial.write(code);
    //if code 1 is recived the connection is stablished
    //turn on the 13 pin led to show connnection
    if(code == '1' || conection){
     digitalWrite(conn,HIGH);
     conection = true;
    }
    if(code){
     switch(code){
       case '2'://vibrate the right side of the chest
         digitalWrite(r_chest,HIGH);
         delay(500);
         break; 
       case '3': //vibrate the left side of the chest
         digitalWrite(l_chest,HIGH);
         delay(500);
         break;
       case '4': //vibrate the back
         digitalWrite(back,HIGH);
         delay(500);
         break;
       case'5': //vibrate all parts
         digitalWrite(l_chest,HIGH);
         digitalWrite(r_chest,HIGH);
         digitalWrite(back,HIGH);
         delay(500);
         break;
       case'9': //Disconect code, turn off the LED and set conection to false
         digitalWrite(conn,LOW);
         conection = false;
         //Serial.close();
         break;
      }
    //reset the code
    code = '0';
    //turn off the motors
    digitalWrite(r_chest,LOW);
    digitalWrite(l_chest,LOW);
    digitalWrite(back,LOW); 
    }
  }
}
