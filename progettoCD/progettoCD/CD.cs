using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progettoCD
{
    class CD
    {
        private string _titolo;

        public string Titolo
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Titolo non valido");
                }

                _titolo = value;
            }

            get
            {
                return _titolo;
            }
        }

        private string _autore;
        public string Autore
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Autore non valido");
                }
                _autore = value;
            }

            get
            {
                return _autore;
            }
        }


        private string _etichetta;
        public string Etichetta
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Etichetta non valida");
                }

                _etichetta = value;
            }

            get
            {
                return _etichetta;
            }
        }


        public List<Brano> Brani { set; get; }

        public CD(string titolo, string autore, string etichetta, List<Brano> brani)
        {
            Titolo = titolo;
            Autore = autore;
            Etichetta = etichetta;
            Etichetta = etichetta;
            Brani = brani;
        }


        public override string ToString()
        {
            //tutti i titoli dei brani
            string ritorno = "";

            foreach (Brano b in Brani)
            {
                ritorno += b.Titolo + " ";
            }

            return ritorno;
        }

        public double Durata()
        {
            double durata = 0;

            foreach (Brano b in Brani)
            {
                durata += b.Durata;
            }

            return durata;
        }
    }
}
