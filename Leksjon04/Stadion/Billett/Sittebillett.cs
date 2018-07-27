using System;
using System.Collections.Generic;
using System.Text;

namespace Stadion.Billett
{
    public class SitteBillett : Billett
    {

        public SitteBillett(string navn, double pris, int rad, int plassnr)
            : base(navn, pris)
        {
            
        }


    }
}
