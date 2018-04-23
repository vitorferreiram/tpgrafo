using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1Grafos
{
    class GrafoMA
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
                MA[v1, v2] = 1;
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
        public int Grau(int vertice)
        {
            int grau = 0;


            return grau;
        }
        public bool Completo()
        {
            bool status = false;

            return status;
        }
        public bool Regular()
        {
            bool status = false;

            return status;
        }
        public void ShowMA()
        {
            
        }
        public void ShowLA()
        {
            for (int i = 0; i < qtVertices; i++)
            {
                Console.Write(i + ": ");

                for (int j = 0; j < qtVertices; j++)
                {
                    Console.Write(MA[i,j]+" ");
                    
                }
                Console.Write("\n");
            }


        }
        public void SequenciaGraus()
        {
            
        }
        public void VerticesAdjacentes(int vertice)
        {
           
        }
        public bool Isolado(int vertice)
        {
            bool status = false;

            return status;
        }
        public bool Impar(int vertice)
        {
            bool status = false;

            return status;
        }
        public bool Par(int vertice)
        {
            bool status = false;

            return status;
        }
        public bool Adjacentes(int v1, int v2)
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
