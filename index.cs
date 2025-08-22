using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _4auka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mes = "";

            WriteLine("Digite um mês: ");
            mes = ReadLine();
            switch (mes)
            {
                case "Janeiro":
                case "Março":
                case "Maio":
                case "Julho":
                case "Agosto":
                case "Outubro":
                case "Dezembro":
                    WriteLine("O mês de {0} tem 31 dias", mes);
                    break;
                case "Fevereiro":
                    WriteLine("O mês de {0} tem 28 dias", mes);
                    break;
                default:
                    WriteLine("O mês de {0} tem 30 dias", mes);
                    break;
            }
            ReadKey();
        }
    }
}