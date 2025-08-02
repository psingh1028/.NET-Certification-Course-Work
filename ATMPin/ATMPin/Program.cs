using System;

public class ATMPin
{
    public static void Main()
    {
        DebitCard card1 = new DebitCard();
        DebitCard card2 = new DebitCard();
        DebitCard card3 = new DebitCard();
        DebitCard card4 = new DebitCard();
        DebitCard card5 = new DebitCard();

        card1.PinCM = "1234"; // valid
        Console.WriteLine(card1.PinCM);
        card2.PinCM = "123456"; // valid
        card3.PinCM = "123"; // invalid, too short
        card4.PinCM = "1234567"; // invalid, too long
        card5.PinCM = "1234a"; // invalid, contains non-digit characters
        card1.PinCM = "12a4"; // invalid, contains non-digit characters
        card1.PinCM = "12"; // invalid, too short

        Console.ReadKey();
    }

}