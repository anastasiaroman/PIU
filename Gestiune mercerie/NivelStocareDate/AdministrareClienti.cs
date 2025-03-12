using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelStocareDate
{
    public class AdministrareClienti
    {
        private const int NR_MAX_CLIENTI = 500;
        private Client[] clienti;
        private int nrClienti;

        public AdministrareClienti()
        {
            clienti = new Client[NR_MAX_CLIENTI];
            nrClienti = 0;
        }

        public void AddClient(Client clientNou)
        {
            if (nrClienti < NR_MAX_CLIENTI)
            {
                clienti[nrClienti] = clientNou;
                nrClienti++;
            }
            else
            {
                Console.WriteLine("Nu mai pot fi adăugați clienți, s-a atins limita maximă!");
            }
        }

        public Client[] GetClienti(out int nrClienti)
        {
            nrClienti = this.nrClienti;
            return clienti;
        }
    }
}
