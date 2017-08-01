int sensorPin = 0;


void setup() {
  // put your setup code here, to run once:
    Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
    int val = analogRead(sensorPin);
    String out = "Pot reads: ";
    Serial.println(val);
}