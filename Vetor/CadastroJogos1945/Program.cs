using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroJogos1945
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] vetJogos = new string[3];

            do
            {

                Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

░░░░░██╗░█████╗░░██████╗░░█████╗░░██████╗
░░░░░██║██╔══██╗██╔════╝░██╔══██╗██╔════╝
░░░░░██║██║░░██║██║░░██╗░██║░░██║╚█████╗░
██╗░░██║██║░░██║██║░░╚██╗██║░░██║░╚═══██╗
╚█████╔╝╚█████╔╝╚██████╔╝╚█████╔╝██████╔╝
░╚════╝░░╚════╝░░╚═════╝░░╚════╝░╚═════╝░");
                


                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Consultar");
                Console.WriteLine("3 - Atualizar");
                Console.WriteLine("4 - Excluir");

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    for (int i = 0; i < vetJogos.Length; i++)
                    {
                        Console.WriteLine($"Informe  o {i + 1}  nome do jogo:");
                        vetJogos[i] = Console.ReadLine();
                    }

                    Console.WriteLine("Para Continuar, pressione a tecla ENTER");
                    Console.ReadKey();

                }
                else if (opcao == 2)
                {
                    for (int i = 0; i < vetJogos.Length; i++)
                    {
                        Console.WriteLine($"Posição: {i+1} | Nome do Jogo: {vetJogos[i]}");
                       
                    }
                    Console.WriteLine("Para Continuar, pressione a tecla ENTER");
                    Console.ReadKey();
                }

                else if (opcao == 3)
                {
                  for(int i = 0; i < vetJogos.Length; i++)
                    {
                        Console.WriteLine("Informe o índice do jogo que deseja aí e o novo nome: ");
                        vetJogos[i] = Console.ReadLine();
                        int indice = int.Parse(Console.ReadLine()) ;
                        if(indice == 1 )
                        
                    }
                }
                else if(opcao == 4)
                {
                    

                }
                Console.Clear();

            } while (true);
            
        }
    }
}
