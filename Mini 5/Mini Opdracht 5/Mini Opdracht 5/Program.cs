using System;

namespace Mini_Opdracht_5
{
    class Auto
    {
        //public Boolean motor;
        //    deur = false;
        //    voorruit = false;
        //    uitlaat = false;

        public Auto(Boolean motor, Boolean deur, Boolean voorruit, Boolean uitlaat)
        {
            motor = false;
            deur = false;
            voorruit = false;
            uitlaat = false;
        }

}
    class Monteur
    {
        public static void Main(string[] args)
        {
            int counter = 0;
            bool[] auto1 = new bool[4] { true, true, true, false };
            //auto1[0] = true;
            //auto1[1] = false;
            //auto1[2] = false;
            //auto1[3] = false;
            foreach (bool i in auto1 )
            {
                if (i == true)
                {
                    counter += 25;
                }
            }
            Console.WriteLine("De kosten zijn: " + counter);
        }
        
    }
    
}

