using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Stoc
    {
        public Produs Produs { get; set; }
        public int Cantitate { get; set; }

        public Stoc(Produs produs, int cantitate)
        {
            Produs = produs;
            Cantitate = cantitate;
        }

        
        public void AdaugaStoc(int cantitateAdaugata)
        {
            Cantitate += cantitateAdaugata;
            Console.WriteLine($"S-au adăugat {cantitateAdaugata} unităti de {Produs.Nume} la stoc.");
        }

        
        public void VindeProdus(int cantitateVanduta)
        {
            if (Cantitate >= cantitateVanduta)
            {
                Cantitate -= cantitateVanduta;
                Console.WriteLine($"S-au vândut {cantitateVanduta} unităti de {Produs.Nume}.");
            }
            else
            {
                Console.WriteLine($"Stoc insuficient pentru a vinde {cantitateVanduta} unităti de {Produs.Nume}.");
            }
        }

        
        public void AfiseazaStoc()
        {
            Console.WriteLine($"Produs: {Produs.Nume}, Cantitate disponibilă: {Cantitate} unităti");
        }
    }
}


