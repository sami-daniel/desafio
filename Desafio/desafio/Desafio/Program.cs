using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Senha novaSenha = new Senha();
            string senha = string.Empty;

            Console.WriteLine("Olá! Bem-vindo ao verificador de senhas seguras!");
            Console.WriteLine("(Caso queira parar de digitar, digite sair)");
            Console.WriteLine();

            while (true)
            {
                Console.Write("Insira suas senhas: (Digite uma em cada linha)");
                while (true)
                {
                    try
                    {
                        senha = Console.ReadLine();
                        Console.WriteLine();
                        break;
                    }
                    catch
                    {
                        Console.WriteLine();
                        Console.Write("Insira sua senha novamente: ");
                    }
                    while (senha == string.Empty)
                    {
                        Console.WriteLine();
                        Console.Write("Sua senha não pode ser vazia. Digite algo para a senha: ");
                        senha = Console.ReadLine();
                        Console.WriteLine();
                    }
                }
                if (senha == "sair")
                    break;
                else
                {
                    novaSenha.ConjuntoSenha.Add(senha);
                    novaSenha.VerificadorDeSenhas(senha);
                }
            }

            Console.WriteLine();

            Console.Write($"Senhas digitadas: ");
            foreach(string senhaDigitada in novaSenha.ConjuntoSenha)
            {
                Console.Write($"{senhaDigitada} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Senhas digitadas e consideradas seguras: ");
            foreach (string senhaDigitada in novaSenha.ConjuntoSenhasSeguras)
            {
                Console.Write($"{senhaDigitada} ");
            }
            Console.WriteLine();
           
        }
    }
}
