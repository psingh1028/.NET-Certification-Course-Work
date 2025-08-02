using System;
using System.Linq;
using System.Windows.Markup;

public class DebitCard
{
    // this repersents the auto initialized property, used for quick code syntax, readibility, and 
    // used for when we dont need any sort of validation logic when assigning a value to the property
    private string _PinAM { get; set; }

    private string _PinCM;

    public string PinCM
    {
        get { return _PinCM; }  // this repersents a maunally written property, used for when we need to add validation logic when assigning a value to the property

        set
        {
            //validation goes here 
            if (!string.IsNullOrEmpty(value) && value.Length >= 4 || value.Length == 6)
            {
                if (value.All(char.IsDigit) == true)
                {
                    Console.WriteLine("valid");
                    _PinCM = value;
                }
                else Console.WriteLine("invalid");
            }
            else Console.WriteLine("invalid");



        } 

    }
}