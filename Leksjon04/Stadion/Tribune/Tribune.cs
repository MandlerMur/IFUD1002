namespace Stadion.Tribune
{
	/// <summary>
	/// Basisklasse Tribunene samt de avledete kalssene Ståtribune, Sittetribune og VIPtribune
	/// </summary>
	public class Tribune
	{
        private double pris; 

		public Tribune(string navn, double pris, int kap)
		{
			Navn = navn;
            Pris = pris;
            Kapasitet = kap;
		}

		public string Navn 
		{
			get;
            private set;
		}

        public double Pris
        {
            get;
            private set;
        }
        
        public int Kapasitet 
		{
			get;
            private set;
		}

        public virtual double Barnepris
        {
            get
            {
               return this.pris/2; 
            }
            private set
            {
                
            }
            
        }

        //Hvor mye er det solgt for
        public double SolgtFor() 
		{
			return AntallSolgtePlasser * Pris;
		}

        //Antall solgte plasser//
        //Virtual venter til kjøretidspunktet og bruker samme klasse som objektet som brukes
        public virtual int AntallSolgtePlasser
        {
            get
            {
                return 0;
            }
        }

        //
   		public override string ToString() 
        {
             return Navn + " har kapasitet " + Kapasitet + " og pris " + Pris + " kroner.";
        }
	}
}

