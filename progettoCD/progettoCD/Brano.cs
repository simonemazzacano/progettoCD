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

        public string Titolo { get => _titolo; set => _titolo = value; }
        public string Autore { get => _autore; set => _autore = value; }
        public int Durata { get => _durata; set => _durata = value; }


        public bool ShortSong(int durata)
        {
            return Durata < durata;
        }
        public override string ToString()
        {
            return "";
        }
    }
}
