using System;

namespace _10._12.Sjukhus
{
    class Program
    {
        static void Main(string[] args)
        {
            Läkare L1 = new Läkare("Kennet", "Gunnarsson", "Läkare", 50, 65000);
            L1.PrintInfo();
            L1.skrivaRecept = true;
            L1.SkrivaRecept();
            
            Sjuksköterska S1 = new Sjuksköterska("Lena", "Larsson", "Sjuksköterska", 20000);
            S1.PrintInfo();
            S1.YearlySalary();
            S1.takeBlood = true;
            S1.TakeBlood();
            
            Patient P1 = new Patient("Gunn", "Svensson", "Patient");
            P1.sickness = "Cancer";
            P1.status = "Kritiskt";
            P1.PrintInfo();
            P1.PatientStatus();
            
        }
    }
}
