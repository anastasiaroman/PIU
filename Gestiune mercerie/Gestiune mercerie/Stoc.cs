using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneMercerie
{
    public class Stoc
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int ID = 0;
        private const int NUME = 1;
        private const int CATEGORIE = 2;

        // data membra privata
        private int[] cantitati;

        // proprietati auto-implemented
        public int IdStoc { get; set; } // identificator unic stoc
        public string Nume { get; set; }
        public string Categorie { get; set; }
        public Stoc StocItem { get; set; }
        public int Cantitate { get; set; }

        public void SetCantitati(int[] _cantitati)
        {
            cantitati = new int[_cantitati.Length];
            _cantitati.CopyTo(cantitati, 0);
        }

        public int[] GetCantitati()
        {
            // returneaza o copie a vectorului pentru a preveni modificarea directa
            return (int[])cantitati.Clone();
        }

        // constructor implicit
        public Stoc()
        {
            Nume = Categorie = string.Empty;
        }

        // constructor cu parametri
        public Stoc(int idStoc, string nume, string categorie)
        {
            this.IdStoc = idStoc;
            this.Nume = nume;
            this.Categorie = categorie;
        }

        public Stoc(Stoc stocItem, int cantitate)
        {
            StocItem = stocItem;
            Cantitate = cantitate;
        }

        // constructor cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
        public Stoc(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            // ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            this.IdStoc = Convert.ToInt32(dateFisier[ID]);
            this.Nume = dateFisier[NUME];
            this.Categorie = dateFisier[CATEGORIE];
        }

        public string Info()
        {
            string info = $"Id:{IdStoc} Nume:{Nume ?? " NECUNOSCUT "} Categorie: {Categorie ?? " NECUNOSCUT "}";
            return info;
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectStocPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                IdStoc.ToString(),
                (Nume ?? " NECUNOSCUT "),
                (Categorie ?? " NECUNOSCUT "));

            return obiectStocPentruFisier;
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


