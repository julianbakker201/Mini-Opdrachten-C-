using System;

namespace Mini_Opdracht_2
{
    class Count_es
    {
        static void Main(string[] args)
        {
            int counter = 0;
            String str1 = "Helemaal te gek!";
            for (int i = 0; i < str1.Length; i++ )
            {
                if (str1[i].Equals('e') == true)
                {
                    counter += 1;
                    //Console.WriteLine("Dit is er een");
                }
                else
                {
                    //Console.WriteLine("Dit is er niet een");
                    continue;
                    
                }
                
            }
            Console.WriteLine(str1 + " heeft " + counter + " e's.");
        }
    }
}
