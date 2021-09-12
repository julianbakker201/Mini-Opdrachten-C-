using System;

namespace Mini_Opdracht_6
{
    class Sort_Alphabetical
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een woord in:");
            String str1 = Console.ReadLine();
            string str1_lower = str1.ToLower();
            Console.WriteLine(str1_lower);
            char[] string_array = str1_lower.ToCharArray();
            Array.Sort(string_array);
            Console.WriteLine(string.Join(", ", string_array));
        }
    }
}
