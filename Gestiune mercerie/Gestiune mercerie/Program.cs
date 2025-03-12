using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneMercerie
{
    class Program
    {
        static void Main(string[] args)
        {
            // Citirea produselor de la tastatură
            Produs produs1 = CitireProdusTastatura();
            int cantitate1 = CitireCantitateTastatura();

            Produs produs2 = CitireProdusTastatura();
            int cantitate2 = CitireCantitateTastatura();

            // Crearea stocurilor pentru produse
            Stoc stoc1 = new Stoc(produs1, cantitate1);
            Stoc stoc2 = new Stoc(produs2, cantitate2);

            // Afișarea detaliilor produselor
            Console.WriteLine(produs1.GetDetalii());
            Console.WriteLine(produs2.GetDetalii());

            // Afișarea stocului inițial
            Console.WriteLine($"Stoc initial: {stoc1.Cantitate} bucati de {stoc1.Produs.Nume}");
            Console.WriteLine($"Stoc initial: {stoc2.Cantitate} bucati de {stoc2.Produs.Nume}");

            // Adăugarea de produse în stoc
            Console.WriteLine("Introduceti cantitatea de adaugat pentru primul produs:");
            stoc1.AdaugaStoc(CitireCantitateTastatura());

            Console.WriteLine("Introduceti cantitatea de adaugat pentru al doilea produs:");
            stoc2.AdaugaStoc(CitireCantitateTastatura());

            // Vânzarea unor produse din stoc
            Console.WriteLine("Introduceți cantitatea de vandut pentru primul produs:");
            int cantitateVanzare1 = CitireCantitateTastatura();
            if (stoc1.VindeProdus(cantitateVanzare1))
                Console.WriteLine($"S-au vandut {cantitateVanzare1} unitati de {stoc1.Produs.Nume}.");
            else
                Console.WriteLine($"Stoc insuficient pentru {stoc1.Produs.Nume}.");

            Console.WriteLine("Introduceti cantitatea de vandut pentru al doilea produs:");
            int cantitateVanzare2 = CitireCantitateTastatura();
            if (stoc2.VindeProdus(cantitateVanzare2))
                Console.WriteLine($"S-au vandut {cantitateVanzare2} unitati de {stoc2.Produs.Nume}.");
            else
                Console.WriteLine($"Stoc insuficient pentru {stoc2.Produs.Nume}.");

            // Afișarea stocului actualizat
            Console.WriteLine($"Stoc actualizat: {stoc1.Cantitate} bucati de {stoc1.Produs.Nume}");
            Console.WriteLine($"Stoc actualizat: {stoc2.Cantitate} bucati de {stoc2.Produs.Nume}");

            Console.ReadLine();
        }

        // Metodă pentru citirea unui produs de la tastatură
        public static Produs CitireProdusTastatura()
        {
            Console.WriteLine("Introduceti numele produsului:");
            string nume = Console.ReadLine();

            Console.WriteLine("Introduceti pretul produsului:");
            decimal pret;
            while (!decimal.TryParse(Console.ReadLine(), out pret) || pret < 0)
            {
                Console.WriteLine("Pret invalid. Introduceti un numar valid:");
            }

            return new Produs(0, nume, pret);
        }

        // Metodă pentru citirea unei cantități de la tastatură
        public static int CitireCantitateTastatura()
        {
            Console.WriteLine("Introduceti cantitatea:");
            int cantitate;
            while (!int.TryParse(Console.ReadLine(), out cantitate) || cantitate < 0)
            {
                Console.WriteLine("Cantitate invalida. Introduceti un numar intreg pozitiv:");
            }

            return cantitate;
        }
    }
}
