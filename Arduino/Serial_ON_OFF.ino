/*
 Simple LED sketch
 */
     
int led = 13; // Pin 13
int blink = 0;
     
void setup()
{
    pinMode(led, OUTPUT); // Set pin 13 as digital out
     
    // Start up serial connection
    Serial.begin(9600); // baud rate
    Serial.flush();
}
     
void loop()
{
    String input = "";
     
    // Read any serial input
    while (Serial.available() > 0)
    {
        input += (char) Serial.read(); // Read in one char at a time
        delay(5); // Delay for 5 ms so the next char has time to be received
    }
     
    if (input == "on")
    {
        blink = 0;
        digitalWrite(led, HIGH); // on
    }
    else if (input == "off")
    {
        blink = 0;
        digitalWrite(led, LOW); // off
    }
    else if (input == "on 1 sec")
    {
        blink = 0;
        digitalWrite(led, HIGH); // on
        delay(1000);
        digitalWrite(led, LOW); // off
    }
    else if (input == "on 2 sec")
    {
        blink = 0;
        digitalWrite(led, HIGH); // on
        delay(2000);
        digitalWrite(led, LOW); // off
    }
    else if (input == "on 5 sec")
    {
        blink = 0;
        digitalWrite(led, HIGH); // on
        delay(5000);
        digitalWrite(led, LOW); // off
    }
    else if (input == "blink")
    {
        blink=1;
    }
    if (blink == 1)
    {
        digitalWrite(led, HIGH); // on
        delay(50);
        digitalWrite(led, LOW); // off
        delay(50);
        digitalWrite(led, HIGH); // on
        delay(50);
        digitalWrite(led, LOW); // off
        delay(500);
    }
}
