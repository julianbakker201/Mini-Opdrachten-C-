using System;

namespace Mini_Opdracht_3
{
    class Addition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer 4 getallen in:");
            
            int counter = 0;
            

            int[] numbers = new int [4];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                
            }

                    
            for (int i = 0; i < numbers.Length; i++)
            {
                counter += numbers[i];
            }


            
            Console.WriteLine("Deze array telt op tot: " + counter);
        }
    }
}
