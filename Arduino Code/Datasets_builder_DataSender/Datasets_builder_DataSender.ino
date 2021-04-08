
void setup() {
  Serial.begin(115200);
}

void loop() {
  if(Serial.available()){
    char c = Serial.read();
    if(c=='1'){
      //send headers
      Serial.println("Field 1;Field 2;Field 3;Label");
    } else if (c=='2'){
      //send data
      String values = String(random(100));
      values+=";";
      values+=String(random(1000));
      values+=";";
      values+=String(random(10));
      values+=";";
      values+="Label 1"; //40;500;9;Label 1
      Serial.println(values);
    }
  }
}
