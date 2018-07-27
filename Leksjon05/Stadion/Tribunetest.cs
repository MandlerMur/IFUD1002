using System;
using Stadion.Tribune;
using Stadion.Billett;
namespace Tribune
{
    class Tribunetest
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Ståtribune feltA = new Ståtribune("Felt A", 50, 1000 );
            Sittetribune feltB = new Sittetribune("Felt B", 250, 200, 20);
            VIPtribune kafeen = new VIPtribune("Kafe Fotball", 1000, 10, 2);
            Ståbillett ståbillett = new Ståbillett(feltA.Navn, feltA.Pris);

            
            
            String res = "";
            res += "Kapasitet på felt A: " + feltA.Kapasitet + "\n";
            res += "Kapasitet på felt B: " + feltB.Kapasitet + "\n";
            res += "Kapasitet i kafeen: " + kafeen.Kapasitet + "\n";
            if (feltA.SelgPlasser(20)) res += "20 plasser solgt\n";
            else res += "Ikke nok plass\n";
            if (feltB.SelgPlasser(10)) res += "10 plasser solgt\n";
            else res += "Ikke nok plass\n";
            if (kafeen.SelgPlasser(8)) res += "8 plasser solgt\n";
            else res += "Ikke nok plass\n";
            if (kafeen.SelgPlasser(5)) res += "5 plasser solgt\n";
            else res += "Ikke nok plass\n";
            if (feltB.SelgPlasser(50)) res += "50 plasser solgt\n";
            else res += "Ikke nok plass\n";
  /*          double solgtFor = feltA.AntallSolgtePlasser * feltA.Pris;
            solgtFor += feltB.AntallSolgtePlasser * feltB.Pris;
            solgtFor += kafeen.AntallSolgtePlasser * kafeen.Pris;*/
            double solgtFor = feltA.SolgtFor() + feltB.SolgtFor() + kafeen.SolgtFor();
            res += "Solgt for: " + solgtFor + " kroner\n";

            Console.WriteLine(res, "Tribuner");
            Console.WriteLine(ståbillett.ToString());


        }
    }
}
