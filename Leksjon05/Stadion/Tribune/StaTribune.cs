using Stadion.Billett;
using System.Collections.Generic;

namespace Stadion.Tribune
{
    public class Ståtribune : Tribune
    {
        private int antallSolgtePlasser;
        string navn;    


        public Ståtribune(string navn, double pris, int kap)
            : base(navn, pris, kap)
        {
            antallSolgtePlasser = 0;
        }
        public override int AntallSolgtePlasser
        {
            get
            {
                return antallSolgtePlasser;
            }
        }

        public bool SelgPlasser(int antall)
        {
            if (AntallSolgtePlasser + antall <= Kapasitet)
            {
                antallSolgtePlasser += antall;
                return true;
            }
            else return false;
        }

        public KjøpBillett(int antVoksne, int antBarn)
        {
            double barnepris = Barnepris;
            double pris = Pris;

        
            for (int i = 0; i < antVoksne; i++)
            {
                Ståbillett ståbillett = new Ståbillett(navn, pris);
                return ;
            }

            for (int i = 0; i < antVoksne; i++)
            {
                Ståbillett ståbillett = new Ståbillett(navn, barnepris);
                return;
            }

        }
    }
}
