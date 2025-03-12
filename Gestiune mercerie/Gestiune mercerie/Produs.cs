using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneMercerie
{
    public class Produs
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public decimal Pret { get; set; }

        // Constructor implicit
        public Produs()
        {
            Id = 0;
            Nume = "Necunoscut";
            Pret = 0;
        }

        // Constructor cu parametri
        public Produs(int id, string nume, decimal pret)
        {
            Id = id;
            Nume = nume;
            Pret = pret;
        }

        // Metodă pentru obținerea detaliilor produsului ca string
        public string GetDetalii()
        {
            return $"ID: {Id}, Nume: {Nume}, Pret: {Pret} RON";
        }
    }
}
