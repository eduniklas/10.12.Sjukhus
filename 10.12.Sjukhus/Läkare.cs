using System;
using System.Collections.Generic;
using System.Text;

namespace _10._12.Sjukhus
{
    class Läkare : Person
    {
        public Läkare(string firstName, string lastName, string role, int workTime, int salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Role = role;
            this.WorkTime = workTime;
            this.Salary = salary;
        }
        public bool skrivaRecept { get; set; }
        
        public void SkrivaRecept()
        {
            if (skrivaRecept == true)
            {
                Console.WriteLine(Role + " " + FirstName + " " + LastName + " skriver ut Ritalin");
            }
        }
        public override void PrintInfo()
        {
            Console.WriteLine(FirstName + " " + LastName + ": " + Role + "\nMånadslön: " + Salary + "kr. Arbetstid/vecka: " + WorkTime + "timmar");
        }
    }
}
