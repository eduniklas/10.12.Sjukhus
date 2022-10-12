using System;
using System.Collections.Generic;
using System.Text;

namespace _10._12.Sjukhus
{
    public abstract class Person
    {
        public string FirstName;
        public string LastName;
        public int Salary;
        public int WorkTime;
        public string Role;
        public abstract void PrintInfo();
    }
    
}
