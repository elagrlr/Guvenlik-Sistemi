#include <MFRC522.h> 
#include<SPI.h>
  
int RST_PIN=9;
int SS_PIN=10;  
int PIR=2;
bool durum = 0;
bool oku=0;
MFRC522 kartOkuyucu(SS_PIN, RST_PIN); 
byte ID[4] = {
  181,
  174,
  141,
  35
}; 

 
void setup() { 
  pinMode(PIR, INPUT); 
  Serial.begin(9600); 
  SPI.begin(); 
  kartOkuyucu.PCD_Init(); 
 
}
 void loop() {
  hareketFonksiyonu();
   delay(2000); 
 }

void hareketFonksiyonu(){
  
 durum = digitalRead(PIR);
 
  
  if ( durum==1) { 
 
    delay(2000);
     if (kartOkuyucu.PICC_IsNewCardPresent()) { 
       if (kartOkuyucu.PICC_ReadCardSerial()) { 
         if (kartOkuyucu.uid.uidByte[0] == ID[0] && kartOkuyucu.uid.uidByte[1] == ID[1] &&kartOkuyucu.uid.uidByte[2] == ID[2] &&kartOkuyucu.uid.uidByte[3] == ID[3]) {              
              durum=0;
              oku=1;
              Serial.print(oku);
              Serial.print("/");
              Serial.println(durum);
              delay(1000);  
            }  
          else{
               oku=1;
               Serial.print(oku);
               Serial.print("/");
               Serial.println(durum);
               delay(1000);    
             } 
          } 
      oku=0;
    }
  else if(durum==1&& oku==0){
       
    Serial.print(oku);
    Serial.print("/");           
    Serial.println(durum);          
    delay(1000);                      
    }  
       
      kartOkuyucu.PICC_HaltA(); 
  }  
}
 