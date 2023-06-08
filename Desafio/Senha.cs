using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Senha
    {
        public List<string> ConjuntoSenha = new List<string>();
        public List<string> ConjuntoSenhasSeguras = new List<string>();

        private List<char> ListaDeSimbolos = new List<char>()
        {
            '!', '@', '#', '$', '%', '&', '*', '+', '-', '=', '/', ',', '<', '>', '?', '|', '~'
        };

        public void VerificadorDeSenhas(string senha)
        {
            bool PossuiSeteCaracteres = false;
            bool PossuiSimbolo = false;
            bool PossuiLetraMaiuscula = false;
            bool PossuiLetraMinuscula = false;

            if (senha.Length >= 7)
            {
                PossuiSeteCaracteres = true;
            }
            foreach (char caractere in senha)
            {
                if (char.IsUpper(caractere))
                    PossuiLetraMaiuscula = true;
                else if (char.IsLower(caractere))
                    PossuiLetraMinuscula = true;
                else if (ListaDeSimbolos.Contains(caractere))
                    PossuiSimbolo = true;
            }
            if (PossuiSeteCaracteres && PossuiSimbolo && PossuiLetraMaiuscula && PossuiLetraMinuscula)
            {
                ConjuntoSenhasSeguras.Add(senha);
            }
        }
    }
}
