//[encoderNr,pinA,pinB,lastValue,pinALOWvalue,CurrentValue]
int knobs[2][6] = {{1,3,4,0,0,0}
                  ,{2,5,6,0,0,0}
                  };
boolean bCW;

void setup() {
   /* Read Pin A
   Whatever state it's in will reflect the last position   
   */
   for(int i = 0; i<2;i++){
    pinMode (knobs[i][1],INPUT);
    pinMode (knobs[i][2],INPUT);
    knobs[i][3] = digitalRead(knobs[i][1]);
    knobs[i][4] = knobs[i][3];
   }
   Serial.begin (115200);
} 

 void loop(){
  for(int i = 0; i < 2; i++){
    readEncoder(knobs[i]);
  }
 }

 void readEncoder(int *knob) { 
   knob[5] = digitalRead(knob[1]);
   if (knob[5] != knob[3] && knob[5] != knob[4]){ // Means the knob is rotating
     // if the knob is rotating, we need to determine direction
     // We do that by reading pin B.
     if (digitalRead(knob[2]) != knob[5]) {  // Means pin A Changed first - We're Rotating Clockwise
       bCW = true;
     } else {// Otherwise B changed first and we're moving CCW
       bCW = false;
     }
     //Serial.print(knob[0]);
     //Serial.print (" coRotated: ");
     if (bCW){
       //Serial.println (" clockwise");
       Serial.println(knob[0]);
     }else{
       //Serial.println(" counterclockwise");
       Serial.print("-");
       Serial.println(knob[0]);
     }
     //Serial.print("Encoder Position: ");
     //Serial.println(encoderPosCount);
      
     delay(100);
   } 
   knob[3] = knob[5];
   
 } 
