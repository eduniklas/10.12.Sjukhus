using System;
using System.Collections.Generic;
using System.Text;

namespace _10._12.Sjukhus
{
    class Sjuksköterska : Person
    {
        public Sjuksköterska(string firstName, string lastName, string role, int salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Role = role;
            this.Salary = salary;
        }
        public bool takeBlood { get; set; }
        public void TakeBlood()
        {
            if (takeBlood == true)
            {
                Console.WriteLine(Role + " " + LastName + " tar ett blodprov");
            }
        }
        public void YearlySalary()
        {
            Console.WriteLine(Role + " " + FirstName + " " + LastName + "s årslön är: " + Salary*12 + "kr");
        }
        public override void PrintInfo()
        {
            Console.WriteLine("\n" + FirstName  + " " + LastName + ": " + Role + "\nMånadslön: " + Salary + "kr");
        }
    }
}
