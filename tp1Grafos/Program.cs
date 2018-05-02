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

                Console.WriteLine("1. Matriz de Adjacência");
                Console.WriteLine("2. Lista de Adjacência");
                Console.WriteLine("\n0. Sair");

                Console.WriteLine("\n\nDigite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());


            if (opcao == 1)
            {
                //MA

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
                    Console.WriteLine("10. Vértices adjacentes");
                    Console.WriteLine("11. Isolado");
                    Console.WriteLine("12. Impar");
                    Console.WriteLine("13. Par");
                    Console.WriteLine("14. Adjacentes");


                    Console.WriteLine("\n0. Sair");

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

                            Console.WriteLine(grafoMA.InserirAresta(v1, v2));
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
                            Console.Clear();
                            Console.WriteLine("A ordem do grafo é igual a " + grafoMA.Ordem());
                            Console.ReadKey();

                            break;

                        case (4): //GRAU
                            Console.Clear();
                            Console.WriteLine("Digite o vértice desejado: ");
                            v1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("O grau do vértice é " + grafoMA.Grau(v1));
                            Console.ReadKey();

                            break;

                        case (5): //COMPLETO
                            Console.Clear();
                            Console.WriteLine(grafoMA.Completo());
                            Console.ReadKey();

                            break;

                        case (6): //REGULAR
                            Console.Clear();
                            Console.WriteLine("- Grafo Regular - ");

                            Console.WriteLine(grafoMA.Regular());
                            Console.ReadKey();

                            break;

                        case (7)://Matriz de adjacência
                            Console.Clear();
                            Console.WriteLine("Matriz de adjacência: \n\n");

                            grafoMA.ShowMA();

                            Console.WriteLine("\n\nAperte qualquer tecla para voltar");
                            Console.ReadKey();
                            break;

                        case (8)://Lista de adjacência
                            Console.Clear();
                            Console.WriteLine("Lista de adjacência: \n\n");

                            grafoMA.ShowLA();

                            Console.WriteLine("\n\nAperte qualquer tecla para voltar");
                            Console.ReadKey();
                            break;

                        case (9): //SEQUÊNCIA DE GRAUS
                            Console.Clear();
                            Console.WriteLine("- Sequência de graus -\n\n");

                            grafoMA.SequenciaGraus();

                            Console.ReadKey();

                            break;

                        case (10): //VÉRTICES ADJACENTES
                            Console.Clear();
                            Console.WriteLine("Digite o vértice desejado: ");
                            v1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("- Vértices adjacentes a " + v1 + " -\n\n");
                            grafoMA.VerticesAdjacentes(v1);

                            Console.ReadKey();

                            break;

                        case (11): //ISOLADO
                            Console.Clear();
                            Console.WriteLine("Digite o vértice desejado: ");
                            v1 = int.Parse(Console.ReadLine());

                            Console.WriteLine(grafoMA.Isolado(v1));
                            Console.ReadKey();

                            break;

                        case (12): //IMPAR
                            Console.Clear();
                            Console.WriteLine("Digite o vértice desejado: ");
                            v1 = int.Parse(Console.ReadLine());

                            Console.WriteLine(grafoMA.Impar(v1));
                            Console.ReadKey();

                            break;

                        case (13): //PAR
                            Console.Clear();
                            Console.WriteLine("Digite o vértice desejado: ");
                            v1 = int.Parse(Console.ReadLine());

                            Console.WriteLine(grafoMA.Par(v1));
                            Console.ReadKey();

                            break;

                        case (14): //ADJACENTES
                            Console.Clear();
                            Console.WriteLine("- Adjacentes - \n\n");


                            Console.WriteLine("Digite o valor da primeira aresta: ");
                            v1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Digite o valor da segunda aresta: ");
                            v2 = int.Parse(Console.ReadLine());

                            Console.WriteLine(grafoMA.Adjacentes(v1, v2));
                            Console.ReadKey();

                            break;

                        case (0):

                            break;

                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                } while (opcao != 0);

            }

            else if (opcao == 2) //LA
            {
                Console.Clear();
                Console.WriteLine("- Lista de Adjacencia -\n\n");

                Console.WriteLine("Defina a quantidade de vertices: ");
                int nVertices = int.Parse(Console.ReadLine());

                GrafoLA grafoLA = new GrafoLA();

                //opções da lista de adjacencia 
                do
                {
                    Console.Clear();

                    Console.WriteLine("1. Inserir Aresta");
                    Console.WriteLine("2. Remover Aresta");
                    Console.WriteLine("3. Inserir Vertice");
                    Console.WriteLine("4. Remover Vertice");
                    Console.WriteLine("5. Ordem");
                    Console.WriteLine("6. Grau");
                    Console.WriteLine("7. Completo");
                    Console.WriteLine("8. Regular");
                    Console.WriteLine("9. Exibir LA");
                    Console.WriteLine("10. Sequência de graus");
                    Console.WriteLine("11. Vértices adjacentes");
                    Console.WriteLine("12. Isolado");
                    Console.WriteLine("13. Impar");
                    Console.WriteLine("14. Par");
                    Console.WriteLine("15. Adjacentes");


                    Console.WriteLine("\n0. Sair");

                    Console.WriteLine("\n\nDigite a opção desejada: ");
                    opcao = int.Parse(Console.ReadLine());


                    switch (opcao)
                    {
                        case (1)://Inserir Aresta
                            Console.Clear();
                            Console.WriteLine("- Inserir Aresta - \n\n");


                            Console.WriteLine("Digite o valor da primeira aresta: ");
                            int v1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Digite o valor da segunda aresta: ");
                            int v2 = int.Parse(Console.ReadLine());

                            Console.WriteLine(grafoLA.InserirAresta(v1, v2));
                            Console.ReadKey();

                            break;

                        case (2)://Remover Aresta
                            Console.Clear();
                            Console.WriteLine("- Remover Aresta - \n\n");


                            Console.WriteLine("Digite o valor da primeira aresta: ");
                            v1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Digite o valor da segunda aresta: ");
                            v2 = int.Parse(Console.ReadLine());

                            Console.WriteLine(grafoLA.RemoverAresta(v1, v2));
                            Console.ReadKey();

                            break;

                        case (3)://Inserir Vertice
                            Console.Clear();
                            Console.WriteLine("- Inserir Vertice - \n\n");

                            Console.WriteLine("Digite o valor do vertice");
                            int vertice = int.Parse(Console.ReadLine());

                            Console.WriteLine(grafoLA.InserirVertice(vertice));
                            Console.ReadKey();

                            break;

                        case (4)://Remover Vertice
                            Console.Clear();
                            Console.WriteLine("- Remover Vertice - \n\n");

                            Console.WriteLine("Digite o valor do vertice");
                            vertice = int.Parse(Console.ReadLine());

                            Console.WriteLine(grafoLA.RemoverVertice(vertice));
                            Console.ReadKey();

                            break;

                        case (5)://Ordem = nVertices
                            Console.Clear();
                            Console.WriteLine("A ordem do grafo é igual a " + grafoLA.Ordem());
                            Console.ReadKey();

                            break;

                        case (6): // Grau 
                            Console.Clear();
                            Console.WriteLine("Digite o vértice desejado: ");
                            v1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("O grau do vértice é " + grafoLA.Grau(v1));
                            Console.ReadKey();

                            break;
                        case (7): // Grafo Completo 
                            Console.Clear();
                            Console.WriteLine("- Grafo Completo - ");
                            Console.WriteLine(grafoLA.Completo());
                            Console.ReadKey();

                            break;

                        case (8): // Grafo Regular
                            Console.Clear();
                            Console.WriteLine("- Grafo Regular - ");

                            Console.WriteLine(grafoLA.Regular());
                            Console.ReadKey();

                            break;

                        case (9): //LA
                            Console.Clear();
                            Console.WriteLine("Lista de Adjacencia: \n\n");

                            grafoLA.ShowLA();

                            Console.WriteLine("\n\nAperte qualquer tecla para voltar");
                            Console.ReadKey();
                            break;

                        case (10):// Sequencia de Graus 
                            Console.Clear();
                            Console.WriteLine("- Sequência de graus -\n\n");

                            grafoLA.SequenciaGraus();

                            Console.ReadKey();
                            break;
                        case (11):// Vertices Adjacentes
                            Console.Clear();
                            Console.WriteLine("Digite o vértice desejado: ");
                            v1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("- Vértices adjacentes a " + v1 + " -\n\n");
                            grafoLA.VerticesAdjacentes(v1);

                            Console.ReadKey();
                            break;

                        case (12):// Vertice Isolado
                            Console.Clear();
                            Console.WriteLine("Digite o vértice desejado: ");
                            v1 = int.Parse(Console.ReadLine());

                            Console.WriteLine(grafoLA.Isolado(v1));
                            Console.ReadKey();

                            break;
                        case (13): //Vertice Impar
                            Console.Clear();
                            Console.WriteLine("Digite o vértice desejado: ");
                            v1 = int.Parse(Console.ReadLine());

                            Console.WriteLine(grafoLA.Impar(v1));
                            Console.ReadKey();

                            break;

                        case (14): // Vertice Par
                            Console.Clear();
                            Console.WriteLine("Digite o vértice desejado: ");
                            vertice = int.Parse(Console.ReadLine());

                            Console.WriteLine(grafoLA.Par(vertice));
                            Console.ReadKey();


                            break;

                        case (15): // Adjacentes
                            Console.Clear();
                            Console.WriteLine("- Adjacentes - \n\n");


                            Console.WriteLine("Digite o valor da primeira aresta: ");
                            v1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Digite o valor da segunda aresta: ");
                            v2 = int.Parse(Console.ReadLine());

                            Console.WriteLine(grafoLA.Adjacentes(v1, v2));
                            Console.ReadKey();


                            break;

                        case (0):

                            break;

                        default:
                            Console.WriteLine("Opção inválida!");
                            break;

                    }
                } while (opcao != 0);
            }

            else
            {
               //fechar
            }

        }

            
    }
}
