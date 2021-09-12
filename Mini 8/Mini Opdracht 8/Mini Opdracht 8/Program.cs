using System;

namespace Mini_Opdracht_8
{
    class Boot
    {
        public virtual void Starten()
        {
            Console.WriteLine("De boot wordt gestart.");
        }
    }

    class Speedboot : Boot
    {
        public override void Starten()
        {
            Console.WriteLine("De speedboot wordt gestart. VROEM!");
        }
    }

    class Kapitein
    {
        public static void Main()
        {
            Boot bootje = new Boot();
            bootje.Starten();
            if (bootje is Speedboot)
            {
                Console.WriteLine("Ik zet even mijn pet af");
            }
            bootje = new Speedboot();

            bootje.Starten();

            if (bootje is Speedboot)
            {
                Console.WriteLine("Ik zet even mijn pet af");
            }

        }
    }   
}

