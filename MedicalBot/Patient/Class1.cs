using System;

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
    public string GetName()    {return name;}
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
                    if (patient.GetAge() < 18)
                    {
                        patient.SetPrescription("400 mg ibuprofen");
                        break;
                    }
                    else
                        patient.SetPrescription("800 mg ibuprofen");
                    break;
                }
            case "skin rashes":
                {
                    if (patient.GetAge() < 18)
                    {
                        patient.SetPrescription("50 mg diphenhydramine");
                        break;
                    }
                    else
                        patient.SetPrescription("300 mg diphenhydramine");
                    break;
                }
            case "dizziness":
                {
                    if (patient.GetMedicalHistory().ToLower().Contains("diabetes"))
                    {
                        if (patient.GetAge() < 18)
                        {
                            patient.SetPrescription("500 mg metformin");
                            break;
                        }
                        else
                            patient.SetPrescription("500 mg metformin");
                        break;
                    }
                    else
                    {
                        if (patient.GetAge() < 18)
                        {
                            patient.SetPrescription("50 mg diphenhydramine");
                            break;
                        }
                        else
                            patient.SetPrescription("400 mg diphenhydramine");
                        break;
                    }
                }
            default:
                {
                    Console.WriteLine("No prescription available for the given symptom code.");
                    break;
                }
        }
    }



}