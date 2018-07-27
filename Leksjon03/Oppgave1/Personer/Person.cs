using System;

namespace Formue.Personer
{
    public class Person : IComparable
    {
        public Person(string navn, int formue)
        {
            Navn = navn;
            Formue = formue;
        }

        public string Navn { get; private set; }
        public int Formue { get; private set; }

        // Tatt med for å kunne sortere/søke i en List<Person>
        public int CompareTo(Object obj)
        {
            // Hvis obj er av typen Perseon – sammenligner vi
            if (obj is Person)
            {
                Person p = (Person)obj;
                if (p == this) return 0;
                if (Formue == p.Formue) return 0;
                else if (Formue < p.Formue) return 1;
                else if (Formue > p.Formue) return -1;
            }
            return -2;
        }
        /* Likhet dersom navn er like ‐ er med for å bruke Contains‐metoden i en  
           List<Person>*/
        public override bool Equals(object obj)
        {
            if (obj is Person)
            {
                Person p = (Person)obj;
                if (p.Navn.Equals(Navn)) return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Navn.GetHashCode();
        }
        public override string ToString()
        {   // Formaterer for å få fine kolonner
            return Navn.PadRight(20) + " " + Formue.ToString().PadLeft(10);
        }

    }
}
