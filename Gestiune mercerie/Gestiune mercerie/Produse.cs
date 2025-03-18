using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneMercerie
{
    public class Produse
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int ID = 0;
        private const int NUME = 1;
        private const int CATEGORIE = 2;

        // Data membră privată
        private int[] preturi;

        // Proprietăți auto-implemented
        public int IdProdus { get; set; } // identificator unic produs
        public string Nume { get; set; }
        public string Categorie { get; set; }

        public void SetPreturi(int[] _preturi)
        {
            preturi = new int[_preturi.Length];
            _preturi.CopyTo(preturi, 0);
        }

        public int[] GetPreturi()
        {
            // Returnează o copie a vectorului pentru a preveni modificarea directă
            return (int[])preturi.Clone();
        }

        // Constructor implicit
        public Produse()
        {
            Nume = Categorie = string.Empty;
            preturi = new int[0]; // Inițializează vectorul pentru a evita NullReferenceException
        }

        // Constructor cu parametri
        public Produse(int idProdus, string nume, string categorie)
        {
            this.IdProdus = idProdus;
            this.Nume = nume;
            this.Categorie = categorie;
            preturi = new int[0]; // Inițializează preturi
        }

        // Constructor cu un singur parametru de tip string care reprezintă o linie dintr-un fișier text
        public Produse(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            // Ordinea de preluare a câmpurilor este dată de ordinea în care au fost scrise în fișier
            this.IdProdus = Convert.ToInt32(dateFisier[ID]);
            this.Nume = dateFisier[NUME];
            this.Categorie = dateFisier[CATEGORIE];
            preturi = new int[0]; // Inițializează preturi
        }

        public string Info()
        {
            string info = $"Id: {IdProdus} Nume: {Nume ?? "NECUNOSCUT"} Categorie: {Categorie ?? "NECUNOSCUT"}";
            return info;
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectProdusPentruFisier = string.Format("{0}{1}{0}{2}{0}{3}",
                SEPARATOR_PRINCIPAL_FISIER,
                IdProdus.ToString(),
                (Nume ?? "NECUNOSCUT"),
                (Categorie ?? "NECUNOSCUT"));

            return obiectProdusPentruFisier;
        }
    }
}
