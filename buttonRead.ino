int button1 = 8;
int button2 = 7;
int buttonState1 = 0;
int buttonState2 = 0;

int lastState1 = 0;
int lastState2 = 0;

void setup() {
  // put your setup code here, to run once:
    pinMode(button1, INPUT);
    pinMode(button2, INPUT);
    Serial.begin(9600);

}

void loop() {
  // put your main code here, to run repeatedly:
    
    buttonState1 = digitalRead(button1);
    buttonState2 = digitalRead(button2);

    if (buttonState1 != lastState1){

      if (digitalRead(button1)==HIGH){
        Serial.write("1\n");
      }
    }
    if (buttonState2 != lastState2){

        if (digitalRead(button2)==HIGH){
          Serial.write("-1\n");     
        }
    }
      lastState1 = buttonState1;
      lastState2 = buttonState2;
      delay(5);
}