  
 /*
  *MakeIT 3nd tutorial
  *Title : Datasets builder showcase
  *Author : Baptiste ZLOCH (MakeIT owner)
  *Description : create your onw labaled datasets with a simple arduino code and datasets builder. 
  *Date : 21/04/2021
  *Tested with : Arduino nano, UNO, ESP8266 NODEMCU, ESP32, EPS32-CAM, WEMOS D1 R1, but not working with NANO 33 BLE...
  */

void setup() {
  Serial.begin(115200); //Begin serial communication
}

void loop() {
  if(Serial.available()){ //Check if the serial is available
    char c = Serial.read(); //Read the character sent by datasets builder
    if(c=='1'){ //Equals 1 => Send the headers
      Serial.println("Field 1;Field 2;Field 3;Label"); // send headers to datasets builder
    } else if (c=='2'){ //Equals 2 => Send the data
      String values = String(random(100)); //replace with your data
      values+=";";
      values+=String(random(1000)); //replace with your data
      values+=";";
      values+=String(random(10)); //replace with your data
      values+=";";
      values+="Label 1"; //add your own label
      // values = 40;500;9;Label 1
      Serial.println(values); // send data to datasets builder
    }
  }
}
