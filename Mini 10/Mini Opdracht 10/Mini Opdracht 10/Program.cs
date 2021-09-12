using System;
using System.Collections.Generic;

namespace Mini_Opdracht_7
{
    class IkNeemMee
    {
        static void Main(string[] args)
        {
                  
            Console.WriteLine("Vul een woord in en vervolgens moet elk woord beginnen met de laatste letter van het vorige woord.");
            Console.WriteLine("Heb je genoeg speelt typ dan: stop");
            Console.WriteLine("Vul nu je eerste voorwerp in. Succes!");
            Console.WriteLine("Ik ga op vakantie en ik neem mee... ");
            
            string woord = Console.ReadLine();
            char[] woord_array = woord.ToCharArray();
            var woorden = new List<string>();
            woorden.Add(woord);
            Console.WriteLine(woord_array[woord.Length - 1]);
            while (true)
            {
                Console.WriteLine("Je voorwerpen zijn: " + string.Join(", ", woorden));
                
                Console.WriteLine("Volgende voorwerp.");
                
                string invoer = Console.ReadLine();
                char[] invoer_array = invoer.ToCharArray();
                if (invoer.Equals("stop") == true)
                {
                    Console.WriteLine("Leuk dat je meedeed.");
                    break;
                }
                else if (invoer_array[0].Equals(woord_array[woord.Length - 1]) == true)
                {
                    Console.WriteLine("Goede.");
                    woord = invoer;
                    woord_array = woord.ToCharArray();
                    woorden.Add(invoer);
                }
                else if (invoer_array[0].Equals(woord_array[woord.Length - 1]) == false)
                {
                    Console.WriteLine(invoer_array[0]);
                    Console.WriteLine("De begin- en eindletter zijn niet hetzelfde.");
                    Console.WriteLine("Probeer het nogmaals.");


                }
                
            }
        }
    }
}
