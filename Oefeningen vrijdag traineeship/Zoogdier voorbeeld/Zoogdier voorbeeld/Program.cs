using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoogdier z = new Koe();
            Zoogdier z2 = new Zoogdier();
            Koe k = new Koe();
            //     Koe k2 = new Zoogdier();
            z2.hartslag = 77;
            //   z2.horens = 3;
            k.horens = 2;
            k.hartslag = 88;
            z.hartslag = 4;
            //z.horens = 7;   werkt niet ?????
            z2.ademen();
            k.lopen();
            DierenAmbulance da = new DierenAmbulance();
            da.ophalen(k);
            da.ophalen(z2);

        }

    }
    // Domein Model
    class DierenAmbulance
    {
        public void ophalen(Zoogdier zoogdier)
        {
            Console.WriteLine("We halen het zoogdier op " + zoogdier.hartslag + ".");
            //Console.WriteLine(">>"+zoogdier.horens); //

        }
    }

    class Zoogdier
    {
        public int hartslag;
        public void ademen()
        {
            Console.WriteLine("ademen in zoogdier");
        }
    }
    class Koe : Zoogdier
    {
        public int horens;
        public void lopen()
        {
            Console.WriteLine("lopen in koe");
        }
    }

    // Huis Woning    Ja
    // Huis Huis      Ja
    // Woning Huis    Misschien
    // Huis Pizza     Nee
}


//   Has a    GEEN RICHTING  zichtbaarheid Multipliciteit-Kardinaliteit
//  OneToOne OneToMany-ManyToOne   ManyToMany
// null  new Auto()

// Telefoon    ManyToOne      Provider
// Provider    OneToMany      Telefoon

//     Telefoon         OneToOne     Eigenaar
//     Auto serienummer       Mens  Hart

//     Mens   ManyToMany  Telefoon     Homoniem    Boek

//    Is a   WEL RICHTING        Covariant   Inheritance