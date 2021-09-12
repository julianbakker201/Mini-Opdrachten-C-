using System;

namespace Mini_Opdracht_7
{
    class Lingo
    {
        static void Main(string[] args)
        {
            string woord = "exodus";
            char[] woord_array = woord.ToCharArray();
            Console.WriteLine("Welkom bij Lingo! Hieronder vind je een hint over de lengte en succes!");
            Console.WriteLine("_ _ _ _ _ _");

            Console.WriteLine("Doe een poging!");
            int pogingen = 0;
            int[] hint_array = new int[6];
            while (true){
                    string invoer = Console.ReadLine();
                    if (invoer.Length > woord.Length)
                    {
                        Console.WriteLine("Dit woord is te lang. Probeer het nogmaals.");
                        
                    }
                    else if (invoer.Length < woord.Length)
                    {
                        Console.WriteLine("Dit woord is te kort. Probeer het nogmaals.");
                        
                    }
                    else if (invoer.Equals(woord) == true)
                    {
                        Console.WriteLine("Goed gedaan!");
                        pogingen++;
                        Console.WriteLine("Je had " + pogingen + " pogingen nodig.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Helaas is dat niet het juiste woord.");
                        char[] invoer_array = invoer.ToCharArray();
                        int counter = 0;
                        pogingen++;
                        foreach (char i in invoer_array)
                        {
                            if (i.Equals(woord_array[counter]) == true)
                            {
                                hint_array[counter] = 2;
                                counter++;
                                
                                continue;
                            }
                            else if (woord.Contains(i) == true)
                            {
                                hint_array[counter] = 1;
                                counter++;
                                
                                continue;
                            }
                            else
                            {
                                hint_array[counter] = 0;
                                counter++;
                                
                                continue;
                            }
                        }
                        Console.WriteLine("Hier is een hint " + string.Join("", hint_array));
                    }
            } 
        }
    }
}
