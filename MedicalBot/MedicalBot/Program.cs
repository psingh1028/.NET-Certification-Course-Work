using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

public class MedicalBot
{
    const string BotName = "Bob";
    public static string GetBotName()
    {
        return BotName;
    }

    public static void Main(string[] args)
    {


        Patient patient1 = new Patient("guy", 45, "male", "diabetes", "headache");
        Patient patient2 = new Patient("amy", 17, "female", "diabetes", "skin rashes");
        Patient patient3 = new Patient("fred", 49, "male", "diabetes", "dizziness");
        Patient patient4 = new Patient("dude", 16, "male", "diabetes", "dizziness");

        patient1.PrescribeMedication(patient1);
        patient2.PrescribeMedication(patient2);
        patient3.PrescribeMedication(patient3);
        patient4.PrescribeMedication(patient4);

        Console.WriteLine($"Patient Name:{patient1.GetName()} and prescription: {patient1.GetPrescription()}");
        Console.WriteLine($"Patient Name:{patient2.GetName()} and prescription: {patient2.GetPrescription()}");
        Console.WriteLine($"Patient Name:{patient3.GetName()} and prescription: {patient3.GetPrescription()}");
        Console.WriteLine($"Patient Name:{patient4.GetName()} and prescription: {patient4.GetPrescription()}");

        Console.ReadKey();


    }

}