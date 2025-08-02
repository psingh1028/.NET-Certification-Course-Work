using System;

public class TypeConversion
{
    public static void Main()
    {
        byte a = (byte)10; //Conversion
        int b = 10;
        string c = "10.34";
        decimal d = 20.3M;

        //converting byte into short
        short aCon = a;

        //Converting int into short
        short bCon = (short)b;

        //Converting string into double;
        double cCon = double.Parse(c);

        //Converting string into decimal with tryParse
        decimal.TryParse(c, out decimal result);

        //Converting decimal to string
        string dCon = Convert.ToDecimal(d).ToString();

        Console.WriteLine(aCon); Console.WriteLine(bCon);
        Console.WriteLine(cCon); Console.WriteLine(result);
        Console.WriteLine(dCon);

        Console.ReadKey();



    }
}