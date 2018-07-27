using System;

namespace Oppgave1
{
    class Brøk
    {       

        public int Teller {get; set; } //properties//
        public int Nevner { get; set; }

        public Brøk () //standardkonstruktør der Nevner = 1, teller er default 0//
        {            
            Nevner = 1;
        }

        public Brøk (int heltall) //konstruktør 
        {
            Teller = heltall;
            Nevner = 1;
        }

        public Brøk (int teller, int nevner) //konstruktør med to parametere //
        {
            Teller = teller;
            Nevner = nevner;
        }

        public Brøk (Brøk kopi) //kopi av annen brøk //
        {            
            Teller = kopi.Teller;
            Nevner = kopi.Nevner;
        }

        public decimal verdiAvBrøk (Brøk brøk) //finne verdi av teller delt på nevner, formatert til 2 desimaler//
        {
            if (brøk.Teller == 0 || brøk.Nevner == 0)
            {
                return
                0;
            }
            else
            {
                decimal teller = brøk.Teller;
                decimal nevner = brøk.Nevner;
                decimal verdi = teller / nevner;

                return
                verdi;
                
            }
            
        }

        //klassemetode for å finne største felles faktor av en brøk//
        public static int faktor (Brøk brøk) 
        {
            int a = brøk.Teller;
            int b = brøk.Nevner;
            int c = a % b;

            while (c != 0)
            {
                a = b;
                b = c;
                c = a % b;
            }

            return b;
            
        }

        //objektmetode forkortelse av brøk med felles største faktor//
        public Brøk forkortelse (Brøk brøk)
        {
            int f = faktor(brøk);
            int teller = brøk.Teller / f;
            int nevner = brøk.Nevner / f;

            Brøk forkortetBrøk = new Brøk(teller, nevner);

            return forkortetBrøk;            

        }

        //klassemetode
        public static Brøk multiply (Brøk brøk)
        {
            
            int teller = brøk.Teller * brøk.Teller;
            int nevner = brøk.Nevner * brøk.Nevner;

            Brøk multiplyBrøk = new Brøk(teller, nevner);

            return multiplyBrøk;            
        }

        //brøk toString() metode//
        public static string brøkToString (Brøk brøk)
        {
            string teller = brøk.Teller.ToString();
            string nevner = brøk.Nevner.ToString();
            string verdi = decimal.Round(brøk.verdiAvBrøk(brøk), 2, MidpointRounding.AwayFromZero).ToString();
            string returnString = teller + " / " + nevner + " = " + verdi;

            return
            returnString; 
            
        }       


        static void Main()
        {
            Console.WriteLine("Skriv inn teller:");
            int tall1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Skriv inn nevner:");
            int tall2 = Int32.Parse(Console.ReadLine());

            Brøk nyBrøk = new Brøk(tall1, tall2); //opprett ny brøkobjekt

            //kall opp metode for å finne verdi teller / nevner
            Console.WriteLine($@"Brøken {nyBrøk.Teller} delt på {nyBrøk.Nevner} = {decimal.Round(nyBrøk.verdiAvBrøk(nyBrøk), 2, MidpointRounding.AwayFromZero)} ");

            //finne største felles faktor
            Console.WriteLine($@"Største felles faktor av {nyBrøk.Teller} og {nyBrøk.Nevner} er {faktor(nyBrøk)}");
            
            //forkortet brøk
            Console.WriteLine($@"Brøken {nyBrøk.Teller} og {nyBrøk.Nevner} forkortet med deres største felles faktor: {faktor(nyBrøk)}, er:  {nyBrøk.forkortelse(nyBrøk).Teller} / {nyBrøk.forkortelse(nyBrøk).Nevner}");

            //multiplisert brøk
            Console.WriteLine($@"Brøken {nyBrøk.Teller} / {nyBrøk.Nevner} multiplisert med seg selv er: {multiply(nyBrøk).Teller} / {multiply(nyBrøk).Nevner}");

            //kalle opp metode for å skrive ut brøken som en string
            Console.WriteLine($@"Brøken på stringformat:  {brøkToString(nyBrøk)}");




        }
    }
}
