using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vetNomes = new string[3];


            //vetNomes[0] = "Joao";
            //vetNomes[1] = "Saco";
            //vetNomes[2] = "Ryan";

            Console.WriteLine("Informe o primeiro nome: ");
            vetNomes[1] = Console.ReadLine();

            Console.WriteLine("Informe o segundo nome: ");
            vetNomes[0] = Console.ReadLine();

            Console.WriteLine("Informe o terceiro nome: ");
            vetNomes[2] = Console.ReadLine();


            Console.WriteLine("==========Nomes Apresentados abaixo são: =============");

            Console.WriteLine(vetNomes[0]);
            Console.WriteLine(vetNomes[1]);
            Console.WriteLine(vetNomes[2]);





        }
    }
}
