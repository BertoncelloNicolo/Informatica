using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid
{
    class Utente
    {
        string nome;
        string cognome;
        int credito;

        public Utente(string nome, string cognome, int credito)
        {
            Nome = nome;
            Cognome = cognome;
            Credito = credito;
            Nome = nome;
            Cognome = cognome;
            Credito = credito;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public int Credito { get => credito; set => credito = value; }
    }
}
