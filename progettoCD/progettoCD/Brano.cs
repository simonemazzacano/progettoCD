using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progettoCD
{
    class Brano
    {
        private string _titolo, _autore;
        private int _durata;

        public Brano(string titolo, string autore, int durata)
        {
            Titolo = titolo;
            Autore = autore;
            Durata = durata;
        }

        public string Titolo 
        { 
            get => _titolo; 
            private set //il set non serve a parte nel costruttore
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("Titolo non valido");
                _titolo = value;
            }
        }
        public string Autore
        {
            get => _autore;
            private set//il set non serve a parte nel costruttore
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("Autore non valido");
                _autore = value;
            }
        }
        public int Durata 
        { 
            get => _durata;
            private set
            {
                if (value < 0) throw new Exception("Durata brano negativa");
                _durata = value;
            }
        }

        public bool ShortSong(int durata)
        {
            return Durata < durata;
        }
        public override string ToString()
        {
            return $"(Brano)\n" +
                $"Titolo: {Titolo}\nAutore: {Autore}\nDurata: {Durata} sec";
        }
    }
}
