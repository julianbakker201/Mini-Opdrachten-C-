using System;

namespace Mini_Opdracht_4
{
    class Addition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer 10 getallen in:");

            

            int[] sorted_array = new int [10];

            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                numbers[i] = number;
                for (int j = 0; j < sorted_array.Length; j++)
                {
                    if (j + 1 == sorted_array.Length)
                    {
                        //Console.WriteLine("Ik ben aan het einde");

                        for (int k = 0; k < sorted_array.Length - 1; k++)
                        {
                            sorted_array[k] = sorted_array[k + 1];
                        }
                        sorted_array[j] = number;
                        break;
                    
                    }
                    else if (number <= sorted_array[j+1])
                    {
                        //Console.WriteLine("Ik voer iets in");
                        for (int x = 0; x < j; x++)
                        {
                            sorted_array[x] = sorted_array[x + 1];
                        }
                        sorted_array[j] = number;
                        break;
                    }
                    else
                    {
                        continue;
                        
                    }
                }   

            }

            Console.WriteLine("Deze array voerde u in: " + string.Join(", ", numbers));
            Console.WriteLine("En dit is de array na sorteren: " + string.Join(", ", sorted_array));
        }
    }
}
