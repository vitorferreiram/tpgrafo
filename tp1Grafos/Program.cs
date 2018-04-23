using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1Grafos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            
            do
            {
                Console.WriteLine("1. Matriz de Adjacência");
                Console.WriteLine("2. Lista de Adjacência");
                Console.WriteLine("0. Sair");

                Console.WriteLine("\n\nDigite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case (1)://MA

                        Console.Clear();
                        Console.WriteLine("- Matriz de Adjacência -\n\n");

                        Console.WriteLine("Defina a quantidade de vertices: ");
                        int qtdVertices = int.Parse(Console.ReadLine());

                        GrafoMA grafoMA = new GrafoMA(qtdVertices);
                        
                        //opções da matriz de adjacência
                        do
                        {
                            Console.Clear();

                            Console.WriteLine("1. Inserir Aresta");
                            Console.WriteLine("2. Remover Aresta");
                            Console.WriteLine("3. Ordem");
                            Console.WriteLine("4. Grau");
                            Console.WriteLine("5. Completo");
                            Console.WriteLine("6. Regular");
                            Console.WriteLine("7. Exibir MA");
                            Console.WriteLine("8. Exibir LA");
                            Console.WriteLine("9. Sequência de graus");
                            Console.WriteLine("10. Vertices adjacentes");
                            Console.WriteLine("11. Isolado");
                            Console.WriteLine("12. Impar");
                            Console.WriteLine("13. Par");
                            Console.WriteLine("14. Adjacentes");


                            Console.WriteLine("0. Sair");

                            Console.WriteLine("\n\nDigite a opção desejada: ");
                            opcao = int.Parse(Console.ReadLine());

                            switch (opcao)
                            {
                                case (1)://INSERIR ARESTA
                                    Console.Clear();
                                    Console.WriteLine("- Inserir Aresta - \n\n");


                                    Console.WriteLine("Digite o valor da primeira aresta: ");
                                    int v1 = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Digite o valor da segunda aresta: ");
                                    int v2 = int.Parse(Console.ReadLine());

                                    Console.WriteLine(grafoMA.InserirAresta(v1,v2));
                                    Console.ReadKey();

                                    break;

                                case (2)://REMOVER ARESTA
                                    Console.Clear();
                                    Console.WriteLine("- Remover Aresta - \n\n");


                                    Console.WriteLine("Digite o valor da primeira aresta: ");
                                    v1 = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Digite o valor da segunda aresta: ");
                                    v2 = int.Parse(Console.ReadLine());

                                    Console.WriteLine(grafoMA.RemoverAresta(v1, v2));
                                    Console.ReadKey();

                                    break;

                                case (3): //ORDEM
                                    Console.WriteLine("A ordem do grafo é igual a "+grafoMA.Ordem());
                                    Console.ReadKey();

                                    break;

                                case (8):
                                    Console.Clear();
                                    Console.WriteLine("Lista de adjacência: \n\n");

                                    grafoMA.ShowLA();

                                    Console.WriteLine("\n\nAperte qualquer tecla para voltar");
                                    Console.ReadKey();
                                    break;

                                case (14): //ADJACENTES
                                    Console.Clear();
                                    Console.WriteLine("- Adjacentes - \n\n");


                                    Console.WriteLine("Digite o valor da primeira aresta: ");
                                    v1 = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Digite o valor da segunda aresta: ");
                                    v2 = int.Parse(Console.ReadLine());

                                    Console.WriteLine(grafoMA.Adjacentes(v1,v2));
                                    Console.ReadKey();

                                    break;
                                    
                                case (0):

                                    break;

                                default:
                                    Console.WriteLine("Opção inválida!");
                                    break;

                            }
                        } while (opcao != 0);

                        
                        break;

                    case (2)://LA


                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;

                }

                Console.Clear();
            } while (opcao != 0);

        }

            
    }
}
