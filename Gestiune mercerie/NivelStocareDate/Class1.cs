using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelStocareDate
{
    public class AdministrareMercerie
    {
        private const int NR_MAX_MATERIALE = 500;
        private Produse[] produse;
        private int nrProduse;

        public AdministrareMercerie()
        {
            produse = new Produse[NR_MAX_MATERIALE];
            nrProduse = 0;
        }

        public void AddProdus(Produse produsNou)
        {
            if (nrProduse < NR_MAX_MATERIALE)
            {
                produse[nrProduse] = produsNou;
                nrProduse++;
            }
            else
            {
                Console.WriteLine("Nu mai pot fi adaugate produse, s-a atins limita maxima!");
            }
        }

        public Produse[] GetProduse(out int nrProduse)
        {
            nrProduse = this.nrProduse;
            return produse;
        }
    }
}
