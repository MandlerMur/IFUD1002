using Formue.Personer;

namespace Formue.Lister
{
    public class Forumeliste_1
    {
        private Person[] Personer;
        private int antall;

        public Forumeliste_1(int x)
        {
            Personer = new Person[x];
            antall = 0;
        }

        //Registere ny person //
        public bool registerNewPerson(Person p)
        {
            if (antall < Personer.Length)
            {
                Personer[antall] = new Person(p.Navn, p.Formue);
                antall++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < antall; i++)
            {
                res += Personer[i].ToString() + "\n";
            }
            return res;
        }

        public Person getRichest()
        {
            if (Personer != null && antall > 0)
            {
                int richest = 0;
                for (int i = 0; i < antall; i++)
                {
                    if (Personer[richest].Formue < Personer[i].Formue)
                    {
                        richest = i;
                    }
                }
                return Personer[richest];
            }
            else
            {
                return null;
            }

        }

        private Person[] lagKopi()
        {
            Person[] kopi = new Person[antall];
            for (int i = 0; i < antall; i++)
            {
                kopi[i] = new Person(Personer[i].Navn, Personer[i].Formue);
            }
            return kopi;
        }


        public Person[] sorted()
        {
            Person[] sortertTabell = lagKopi();

            if (Personer != null && antall > 0)
            {
                for (int x = 0; x < antall; x++)
                {
                    int richest = x;
                    for (int i = x + 1; i < antall; i++)
                    {
                        if (sortertTabell[i].Formue > sortertTabell[richest].Formue)
                        {
                            richest = i;
                        }
                    }
                    // bytt plass i tabellen // 
                    Person temp = sortertTabell[x];
                    sortertTabell[x] = sortertTabell[richest];
                    sortertTabell[richest] = temp;
                }
            }
            return sortertTabell;


        }
    }
}
