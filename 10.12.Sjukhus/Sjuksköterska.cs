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
                Console.WriteLine(Role + " " + LastName + " Tar ett blodprov");
            }
        }
        public void YearlySalary()
        {
            Console.WriteLine(Role + " " + " årslön är " + Salary*12);
        }
        public override void PrintInfo()
        {
            Console.WriteLine(FirstName + " " + LastName + " " + Role + " " + Salary);
        }
    }
}
