using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

public class MedicalBot
{
    //const string BotName = "Bob";
    //public static string GetBotName()
    //{
    //    return BotName;
    //}

    public static void Main(string[] args)
    {

        Console.WriteLine("Welcome to Medical Bot");
        Console.WriteLine("would you like to get a prescription? (y/n)");

        char response = Console.ReadKey().KeyChar;

        while (response != 'n')
        {
            Patient patient = new Patient();
            Console.WriteLine("\nPlease enter your name:");
            patient.SetName(Console.ReadLine());
            Console.WriteLine("Please enter your age:");
            patient.SetAge(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Please enter your gender:");
            patient.SetGender(Console.ReadLine());
            Console.WriteLine("Please enter your medical history:");
            patient.SetMedicalHistory(Console.ReadLine());

            // ask for symptom code and ask user to choose between options
            Console.WriteLine("Please choose a number to select between the following symptom codes:");
            Console.WriteLine("1. Headache \n2. Skin Rashes \n3. dizziness");
            switch (Console.ReadLine().ToLower())
            {
                case "1":
                    patient.SetSymptomCode("headache");
                    break;
                case "2":
                    patient.SetSymptomCode("skin rashes");
                    break;
                case "3":
                    patient.SetSymptomCode("dizziness");
                    break;
                default:
                    Console.WriteLine("Invalid symptom code. Please try again.");
                    continue;
            }

            patient.PrescribeMedication(patient);
            Console.WriteLine("Would you like to continue? (y/n)");
            response = Console.ReadKey().KeyChar;
        }



        //Patient patient1 = new Patient("guy", 45, "male", "diabetes", "headache");
        //Patient patient2 = new Patient("amy", 17, "female", "diabetes", "skin rashes");
        //Patient patient3 = new Patient("fred", 49, "male", "diabetes", "dizziness");
        //Patient patient4 = new Patient("dude", 16, "male", "diabetes", "dizziness");

        //patient1.PrescribeMedication(patient1);
        //patient2.PrescribeMedication(patient2);
        //patient3.PrescribeMedication(patient3);
        //patient4.PrescribeMedication(patient4);

        //Console.WriteLine($"Patient Name:{patient1.GetName()} and prescription: {patient1.GetPrescription()}");
        //Console.WriteLine($"Patient Name:{patient2.GetName()} and prescription: {patient2.GetPrescription()}");
        //Console.WriteLine($"Patient Name:{patient3.GetName()} and prescription: {patient3.GetPrescription()}");
        //Console.WriteLine($"Patient Name:{patient4.GetName()} and prescription: {patient4.GetPrescription()}");

        Console.ReadKey();


    }

}












