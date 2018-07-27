using System.Collections.Generic;
using Formue.Personer;

namespace Formue.Lister
{
    public class FormueListe_2
    {
        private List<Person> Personer;

        public List<Person> Personer1 { get => Personer; set => Personer = value; }

        public FormueListe_2()
        {
            Personer1 = new List<Person>();
        }
        /* Registrerer ny person, sjekker om personen er registrert fra før først*/
        public bool registrerNyPerson(Person p)
        {
            // Contains kan brukes fordi Equals metoden er implementert i klassen Person
            if (Personer1 != null && !Personer1.Contains(p))
            {
                Personer1.Add(p);
                return true;
            }
            return false;
        }

        // metode som returnerer rikeste person.
        public Person getRichest()
        {
            int maks = 0;
            for (int i = 0; i < Personer1.Count; i++)
            {
                if (Personer1[maks].Formue < Personer1[i].Formue)
                {
                    maks = i;
                }
            }
            return Personer1[maks];
        }
        public List<Person> sorted()
        {
            /* lager en kopi av personlisten og sorterer denne og ikke orginalen.
             * Har laget metoden CompareTo i klassen Person for å kunne bruke metoden  
             * Sort på List<Person> */
            List<Person> sortertTabell = lagKopi();
            sortertTabell.Sort();
            return sortertTabell;
        }
        private List<Person> lagKopi()
        {
            List<Person> kopi = new List<Person>();
            foreach (Person p in Personer1)
            {
                kopi.Add(new Person(p.Navn, p.Formue));
            }
            return kopi;
        }
        public override string ToString()
        {
            string res = "";
            foreach (Person p in Personer1)
            {
                res += p.ToString() + "\n";
            }
            return res;
        }

    }
}

