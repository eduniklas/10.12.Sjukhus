using System;
using System.Collections.Generic;
using System.Text;

namespace _10._12.Sjukhus
{
    class Patient : Person
    {
        string Sickness;
        string Status;
        public string sickness
        { 
            get { return Sickness; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Måste ange sjukdom");
                }
                else
                {
                    Sickness = value;
                }
            }
        }
        public string status
        {
            get { return Status; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Måste ange status på patientens sjukdom");
                }
                else
                {
                    Status = value;
                }
            }
        }
        public Patient(string firstName, string lastName, string role)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Role = role;
        }
        public void PatientStatus()
        {
            Console.WriteLine("Status för " + Role + " " + FirstName + " " + LastName + ": " + Status);
        }
        public override void PrintInfo()
        {
            Console.WriteLine("\n" + FirstName + " " + LastName + ": " + Role + "\nInlagd pga: " + Sickness);
        }
    }
}
