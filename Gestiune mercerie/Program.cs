using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produs produs1 = new Produs(1, "Plus", 5);
            Produs produs2 = new Produs(2, "Lana", 16);

            // Crearea stocurilor pentru produse
            Stoc stoc1 = new Stoc(produs1, 100);
            Stoc stoc2 = new Stoc(produs2, 50);

            // Afișarea detaliilor produselor
            produs1.AfiseazaDetalii();
            produs2.AfiseazaDetalii();

            // Afișarea stocului pentru produse
            stoc1.AfiseazaStoc();
            stoc2.AfiseazaStoc();

            // Adăugarea de produse în stoc
            stoc1.AdaugaStoc(20);
            stoc2.AdaugaStoc(30);

            // Vânzarea unor produse din stoc
            stoc1.VindeProdus(10);
            stoc2.VindeProdus(60); // Stoc insuficient

            // Afișarea stocului actualizat
            stoc1.AfiseazaStoc();
            stoc2.AfiseazaStoc();

            // Așteaptă o apăsare de tastă înainte de a închide consola
            Console.ReadLine();
        }
    }
}
