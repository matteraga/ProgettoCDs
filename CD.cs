using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoCDs
{
    internal class CD
    {
        private string titolo;
        private string autore;
        private List<Brano> brani = new List<Brano>();

        public CD(string titolo, string autore)
        {
            this.titolo = titolo;
            this.autore = autore;

            for (int i = 0; i < 5; i++)
            {
                brani.Add(new Brano("Titolo: " + i, "Autore: " + i, i));
            }
        }

        public string getTitolo()
        {
            return titolo;
        }

        public string getAutore()
        {
            return autore;
        }

        public void setTitolo(string titolo)
        {
            this.titolo = titolo;
        }

        public void setAutore(string autore)
        {
            this.autore = autore;
        }

        public string toString()
        {
            string brani = "";
            foreach (Brano brano in this.brani)
            {
                brani += brano.getTitolo() + "\n";
            }
            return brani;
        }

        public double durata()
        {
            double durata = 0.0;
            foreach (var brano in this.brani)
            {
                durata += brano.getDurata();
            }
            return durata;
        }
    }
}
