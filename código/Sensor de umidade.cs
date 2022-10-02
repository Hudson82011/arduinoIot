


//Senso de umidade usa um pino analogico
const int pinUmidade=A0;



//Led utilizam pinos digitais
const int led5=5;
const int led6=6;
const int led7=7;

//Função para apagar os leds
void ledOff(){
  digitalWrite(led5,LOW);
    digitalWrite(led6,LOW);
    digitalWrite(led7,LOW);
  
}



void setup()
{
  Serial.begin(9600);
  pinMode(pinUmidade, INPUT);
  pinMode(led5,OUTPUT);
  pinMode(led6,OUTPUT);
  pinMode(led7,OUTPUT);
}

void loop()
{
  Serial.println(analogRead(pinUmidade));
  delay(1000);
  
  if(analogRead(pinUmidade)<300){
  Serial.println("Muito seco");
   ledOff();
    digitalWrite(led5,HIGH);
    digitalWrite(led6,HIGH);
    digitalWrite(led7,HIGH);
    
  }else if(analogRead(pinUmidade)>300&&analogRead(pinUmidade)<600){
    Serial.println("Umido");
    ledOff();
     digitalWrite(led5,HIGH);
    digitalWrite(led6,HIGH);
  }else{
     Serial.println("Encharcado");
    ledOff();
    digitalWrite(led5,HIGH);
  
  }
  
  
}