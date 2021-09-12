using System;

namespace Mini_Opdracht_9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var cessna = new Vliegtuig();
            Leeuw kaapleeuw = new Leeuw();
            Spreeuw spreeuwtje = new Spreeuw();
            cessna.kanVliegen(); 
        }
    }
    public interface IVliegend
    {
        void kanVliegen();

    }
 
    public class Vliegtuig : IVliegend
    {
        //public Vliegtuig() 
        //{
        //   this.kanVliegen = "Ik kan vliegen";
        //}
        public void kanVliegen()
        {
            Console.WriteLine("Ik kan vliegen");
        }
    }
    public class Leeuw : IVliegend
    {
        public void kanVliegen()
        {
            Console.WriteLine("Ik kan niet vliegen");
        }

    }
    public class Spreeuw : IVliegend
    {
        public void kanVliegen()
        {
            Console.WriteLine("Ik kan vliegen");
        }
    }
    

}
