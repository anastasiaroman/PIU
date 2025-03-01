using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Produs
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public decimal Pret { get; set; }

        
        public Produs(int id, string nume, decimal pret)
        {
            Id = id;
            Nume = nume;
            Pret = pret;
        }

        
        public void AfiseazaDetalii()
        {
            Console.WriteLine($"ID: {Id}, Nume: {Nume}, Pret: {Pret} RON");
        }
    }
}
