using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoCDs
{
    internal class Brano
    {
        private string titolo;
        private string autore;
        private double durata;

        public Brano(string titolo, string autore, double durata)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.durata = durata;
        }

        public string getTitolo()
        {
            return titolo;
        }

        public string getAutore()
        {
            return autore;
        }

        public double getDurata()
        {
            return durata;
        }

        public void setTitiolo(string titolo)
        {
            this.titolo = titolo;
        }

        public void setAutore(string autore)
        {
            this.autore = autore;
        }

        public void setDurata(double durata)
        {
            this.durata = durata;
        }

        public string toString()
        {
            return $"Titiolo: {titolo}\nAutore: {autore}\nDurata: {durata}";
        }

        public bool shortSong(double durata)
        {
            return durata > this.durata;
        }
    }
}
