using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace tp1Grafos
{
    class GrafoMA //VITOR
    {
        private int[,] MA;
        private int qtVertices;
        
        public GrafoMA(int qtVertices)//inicializa o grafo
        {
            this.qtVertices = qtVertices;

            MA = new int[qtVertices, qtVertices];
        }

        public int Ordem()//quantidade de vertices
        {
            int ordem = 0;

            ordem = qtVertices;

            return ordem;
        }
        public bool InserirAresta(int v1, int v2)//verifica se pode inserir e retorna status
        {
            bool status = false;

            if (v1 < qtVertices && v2 < qtVertices)
            {
                status = true;
                MA[v1, v2] = v2;
            }

            return status;
        }
        public bool RemoverAresta(int v1, int v2)//verifica se pode remover e retorna status
        {
            bool status = false;

            if (v1 < qtVertices && v2 < qtVertices)
            {
                status = true;
                MA[v1, v2] = 0;
            }

            return status;
        }
        public int Grau(int vertice)//quantidade de arestas ligadas no vertice
        {
            int grau = 0;

            for (int i = 0; i < qtVertices; i++)
            {
                if (MA[vertice, i] != 0)
                    grau++;
            }
            
            return grau;
        }
        public bool Completo()//informa se o grafo é completo -- NÃO ESTA FUNCIONANDO!
        {
            bool status = false;
            //int num;
            
            for (int i = 0; i < qtVertices; i++)
            {

                for (int j = 0; j < qtVertices; j++)
                {
                    if (MA[i, j] == 1)
                        status = true;
                    else if (MA[i, i] == 0)
                        status = true;
                    else
                        return false;

                }

            }


            return status;
        }

        public bool Regular()//todos graus iguais = true
        {
            int[] vetRegular = new int[qtVertices];
            bool status = true;

            int grau = 0;

            for (int i = 0; i < qtVertices; i++)
            {
                grau = 0;
                for (int j = 0; j < qtVertices; j++)
                {
                    if (MA[i, i] != 0)
                        grau++;
                }
                vetRegular[i] = grau;
            }

            int num = 0;
            for (int i = 0; i < vetRegular.Length; i++)
            {
                num = vetRegular[i];

                for (int p = 0; p < vetRegular.Length; p++)
                {
                    if (!vetRegular[p].Equals(num))
                    {
                        status = false;
                        break;
                    }
                }
            }

            return status;
        }
        public void ShowMA()//matriz de ajacencia
        {
            for (int i = 0; i < qtVertices; i++)
            {
                for (int j = 0; j < qtVertices; j++)
                {
                    if (MA[i, j] != 0)
                        Console.Write("1 ");
                    else
                        Console.Write(MA[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
        
        public void ShowLA()//lista de ajacencia
        {   

            for (int i = 0; i < qtVertices; i++)
            {
                Console.Write(i + ": ");

                for (int j = 0; j < qtVertices; j++)
                {
                    if(MA[i, j] != 0)
                        Console.Write(MA[i, j] + " ");

                }

                Console.Write("\n");
            }


        }
        public void SequenciaGraus()//sequencia de graus (ordem crescente)
        {
            int grau = 0;
            List<int> vetSeqGrau = new List<int>();

            for (int i = 0; i < qtVertices; i++)
            {
                for (int j = 0; j < qtVertices; j++)
                {
                    if (MA[i, j] != 0)
                        grau++;
                }
                vetSeqGrau.Add(grau);
                grau = 0;
            }

            vetSeqGrau.Sort();//ordenar
            
            foreach(int num in vetSeqGrau)
            {
                Console.Write(num + ", ");
            }

        }
        public void VerticesAdjacentes(int vertice)//informa os vertices adjacentes do vertice recebido por parametro
        {
            Console.Write(vertice+": ");
            for (int i = 0; i < qtVertices; i++)
            {
                if(MA[vertice, i] != 0)
                    Console.Write(MA[vertice, i] + " ");
            }
            

        }
        public bool Isolado(int vertice)//se não possui aresta = true
        {
            bool status = true;
            int qtd = 0;

            for (int i = 0; i < qtVertices; i++)
            {
                if (MA[vertice, i] != 0)
                    qtd++;
            }

            if (qtd > 0)
                status = false;
           

            return status;
        }
        public bool Impar(int vertice)//quantidade de arestas ligadas ao vertice, impar = true
        {
            bool status = false;

            int qtd = 0;

            for (int i = 0; i < qtVertices; i++)
            {
                if (MA[vertice, i] != 0)
                    qtd++;
            }

            if (qtd % 2 != 0)
                status = true;

            return status;
        }
        public bool Par(int vertice)//quantidade de arestas ligadas ao vertice, par = true
        {
            bool status = false;

            int qtd = 0;

            for (int i = 0; i < qtVertices; i++)
            {
                if (MA[vertice, i] != 0)
                    qtd++;
            }

            if (qtd%2 == 0)
                status = true;

            return status;
        }
        public bool Adjacentes(int v1, int v2)//verifica se dois vertices são adjacentes
        {
            bool status;

            if (MA[v1, v2] == 1)
                status = true;
            else
                status = false;


            return status;
        }
    }
}
