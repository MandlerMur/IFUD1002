namespace Stadion.Tribune
{
    public class VIPtribune : Sittetribune
    {
        private string[,] tilskuer;
        private double pris;

        public VIPtribune(string navn, double pris, int kap, int antRader)
            : base(navn, pris, kap, antRader)
        {
            int antPrRad = Kapasitet / AntallRader;
            tilskuer = new string[AntallRader, antPrRad];
        }

        public override double Barnepris
        {
            get
            {
                return this.pris;
            }
  
        }
    }

}
