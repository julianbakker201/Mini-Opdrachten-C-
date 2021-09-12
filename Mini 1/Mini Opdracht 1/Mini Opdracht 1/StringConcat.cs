using System;

namespace Mini_Opdracht_1
{
    class StringConcat
    {
        static void Main(string[] args)
        {
            String str1 = "po";
            String str2 = "ging";
            String str3 = "en";
            String concantenated = String.Concat(str1, str2, str3);
            Console.WriteLine(concantenated);
        }
    }
}
