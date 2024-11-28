using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSElevador
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Instru��es do programa:

             Escreva um programa em C#  para armazenar as informa��es de um elevador dentro de um pr�dio. Deve-se 
             armazenar o andar atual (t�rreo = 0), total de andares no pr�dio (desconsiderando o t�rreo), 
             capacidade do elevador e quantas pessoas est�o presentes nele. Deve-se  tamb�m disponibilizar 
             os seguintes m�todos:

                  � Construtor: que deve receber como par�metros a capacidade do elevador e o total de andares no pr�dio 
                    (os elevadores sempre come�am no t�rreo e vazio);

                  � Entrar: para acrescentar uma pessoa no elevador (s� deve acrescentar se ainda houver espa�o);

                  � Sair: para remover uma pessoa do elevador (s� deve remover se houver algu�m dentro dele);

                  � Subir: para subir um andar (n�o deve subir se j� estiver no �ltimo andar);

                  � Descer: para descer um andar (n�o deve descer se j� estiver no t�rreo).

             Encapsular todos os atributos da classe (criar os m�todos e propriedades necess�rias).
             */

            int capacidade = 5;
            int quantitativo = 5;
            string op = "A";

            Elevador E = new Elevador(capacidade, quantitativo);

            do // O Do..While (Fa�a..Enquanto/Continua) testa a condi��o s� no final
            {
                E.menu();
                op = Console.ReadLine();

                switch (op.ToUpper())
                {
                    case "1":
                        Console.Clear();
                        E.Entrar();
                        break;

                    case "2":
                        Console.Clear();
                        E.Sair();
                        break;

                    case "3":
                        Console.Clear();
                        E.Subir();
                        break;

                    case "4":
                        Console.Clear();
                        E.Descer();
                        Console.Clear();
                        break;

                    case "Q":
                        Console.Clear();
                        Console.Write("\n\n\n\n\n          - - - - - - - - - - - - - - - - ");
                        Console.Write("\n\t |                               |");
                        Console.Write("\n\n\t |                               |");
                        Console.Write("\n\n\t |     Saindo do programa...     |");
                        Console.Write("\n\n\t |                               |");
                        Console.Write("\n\n\t |                               |");
                        Console.WriteLine("\n          - - - - - - - - - - - - - - - - \n");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("\nErro! Op��o incorreta, tente novamente. \n");
                        Console.ReadKey();
                        break;
                }
            } while (op.ToUpper() != "Q");
            Console.ReadKey();
        }
    }
}
