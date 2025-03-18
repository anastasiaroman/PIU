using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelStocareDate
{
    public class AdministrareProduse
    {
        public class AdministrareProduse
        {
            private const int NR_MAX_PRODUSE = 500;
            private Produs[] produse;
            private int nrProduse;

            public AdministrareProduse()
            {
                produse = new Produs[NR_MAX_PRODUSE];
                nrProduse = 0;
            }

            public void AddProdus(Produs produsNou)
            {
                if (nrProduse < NR_MAX_PRODUSE)
                {
                    produse[nrProduse] = produsNou;
                    nrProduse++;
                }
                else
                {
                    Console.WriteLine("Nu mai pot fi adăugate produse, s-a atins limita maximă!");
                }
            }

            public Produs[] GetProduse(out int nrProduse)
            {
                nrProduse = this.nrProduse;
                return produse;
            }
        }
    }
}
