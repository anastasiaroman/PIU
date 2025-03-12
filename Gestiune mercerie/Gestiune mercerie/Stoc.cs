using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneMercerie
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

        // Metodă pentru adăugarea stocului
        public void AdaugaStoc(int cantitateAdaugata)
        {
            Cantitate += cantitateAdaugata;
        }

        // Metodă pentru vânzare care returnează true/false dacă vânzarea este posibilă
        public bool VindeProdus(int cantitateVanduta)
        {
            if (Cantitate >= cantitateVanduta)
            {
                Cantitate -= cantitateVanduta;
                return true; // Vânzarea a fost realizată cu succes
            }
            return false; // Stoc insuficient
        }
    }
}


