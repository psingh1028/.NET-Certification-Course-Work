using System;
using System.Security.Cryptography.X509Certificates;

public class Patient
{
    string name;
    int age;
    string gender;
    string medicalHistory;
    string symptomCode;
    string prescription;

    public Patient(string name = "unknown", int age = -1, string gender = "unknown",
        string medicalHistory = "unknown", string symptomCode = "unknown", string prescription = "unknown")
    {
        this.name = name;
        this.age = age;
        this.gender = gender;
        this.medicalHistory = medicalHistory;
        this.symptomCode = symptomCode;
        this.prescription = prescription;
    }
    //getters
    public string GetName() { return name; }
    public int GetAge() { return age; }
    public string GetGender() { return gender; }
    public string GetMedicalHistory() { return medicalHistory; }
    public string GetSymptomCode() { return symptomCode; }
    public string GetPrescription() { return prescription; }

    //setters
    public void SetName(string name)
    {
        this.name = name;
    }
    public void SetAge(int age) { this.age = age; }
    public void SetGender(string gender) { this.gender = gender; }
    public void SetMedicalHistory(string medicalHistory) { this.medicalHistory = medicalHistory; }
    public void SetSymptomCode(string symptomCode) { this.symptomCode = symptomCode; }
    public void SetPrescription(string prescription) { this.prescription = prescription; }

    public void PrescribeMedication(Patient patient)
    {
        switch (patient.GetSymptomCode().ToLower())
        {
            case "headache":
                {
                    patient.SetPrescription("ibuprofen");
                    Console.WriteLine("Medical Bot recommends " + GetDosage(patient.GetPrescription()) + " of " + patient.GetPrescription());
                    break;
                }
            case "skin rashes":
                {
                    patient.SetPrescription("diphenhydramine");
                    Console.WriteLine("Medical Bot recommends " + GetDosage(patient.GetPrescription()) + " of " + patient.GetPrescription());
                    break;
                }
            case "dizziness":
                {
                    if (patient.GetMedicalHistory().ToLower().Contains("diabetes"))
                    {
                        patient.SetPrescription("metformin");
                        Console.WriteLine("Medical Bot recommends " + GetDosage(patient.GetPrescription()) + " of " + patient.GetPrescription());
                        break;
                    }
                    else
                    {
                        patient.SetPrescription("diphenhydramine");
                        Console.WriteLine("Medical Bot recommends " + GetDosage(patient.GetPrescription()) + " of " + patient.GetPrescription());
                        break;
                    }
                }
            default:
                {
                    Console.WriteLine("No prescription available for the given symptom code.");
                    break;
                }

                string GetDosage(string medicine)
                {
                    if (medicine == "ibuprofen")
                    {
                        return patient.GetAge() < 18 ? "400 mg" : "800 mg";
                    }
                    else if (medicine == "diphenhydramine")
                    {
                        return patient.GetAge() < 18 ? "50 mg" : "300 mg";
                    }
                    else if (medicine == "metformin")
                    {
                        return patient.GetAge() < 18 ? "500 mg" : "500 mg";
                    }
                    else
                    {
                        return "unknown dosage";
                    }
                }
        }



    }





}



