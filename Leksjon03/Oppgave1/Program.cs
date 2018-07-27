using System;
using Formue.Lister;
using Formue.Personer;
using System.Collections.Generic;

namespace Formue
{
    public class EntryPoint
    {        
        static void Main()
        {
            Forumeliste_1 fl1 = new Forumeliste_1(100);
            FormueListe_2 fl2 = new FormueListe_2();
            

            bool stop = false;
            while (!stop)
            {
                Console.WriteLine("Vil du registrere ny person? Y /N");
                string answer = Console.ReadLine().ToUpper();
                
                if (answer == "N")
                {
                    stop = true; 
                }
                else if (answer == "Y")
                {   
                    //registrere ny person
                    Console.WriteLine("Navn: ");
                    string navn = Console.ReadLine();
                    Console.WriteLine("Formue: ");
                    int formue = Int32.Parse(Console.ReadLine());

                    fl1.registerNewPerson(new Person(navn, formue));
                    fl2.registrerNyPerson(new Person(navn, formue));
                }
                else
                {
                    Console.Clear();
                    stop = false;
                    
                }
            }

            //skriv ut listen usortert
            Console.WriteLine("Usortert liste: (Oppgave 1) ");
            Console.WriteLine(fl1.ToString());
            Console.WriteLine();
            Console.WriteLine("Usortert liste: (Oppgave 2)");
            Console.WriteLine(fl2.ToString());
            Console.WriteLine();

            //finn den rikeste
            Console.WriteLine("Den rikeste i landet er: (Oppgave 1) ");
            Console.WriteLine(fl1.getRichest());
            Console.WriteLine();
            Console.WriteLine("Den rikeste i landet er: (Oppgave 2) ");
            Console.WriteLine(fl2.getRichest());
            Console.WriteLine();

            //tabell sortert etter den rikeste
            Console.WriteLine("De rikeste i landet sortert på inntekt høy - lav: (Oppgave 1)");
            Person[] sortertListe1 = fl1.sorted();
            for (int i = 0; i < sortertListe1.Length; i++)
            {
                Console.WriteLine(String.Format(sortertListe1[i].ToString() + "\t\t" ));
            }
            Console.WriteLine();
            Console.WriteLine("De rikeste i landet sortert på inntekt høy - lav: (Oppgave 2)");
            List<Person> sortertListe2 = fl2.sorted();
            int inList = sortertListe2.Count;
            for (int i = 0; i < inList; i++)
            {
                Console.WriteLine(sortertListe2[i].ToString() + "\t\t");
            }



        }
    }
}
