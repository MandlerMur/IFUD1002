using System;
using System.Collections.Generic;
using System.Text;


namespace Stadion.Billett
{
    public class Billett
    {
        public Billett()
        {

        }

        public Billett (string tribunenavn, double pris)
        {
            Tribunenavn = tribunenavn;
            Pris = pris;
        }

        public string Tribunenavn { get; private set; }
        public double Pris { get; private set; }


        public override string ToString()
        {
            return Tribunenavn + " har pris " + Pris + " kroner.";
        }

    }


}
