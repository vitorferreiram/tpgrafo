using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace tp1Grafos
{

    class GrafoLA // Carolina
    {
        private ArrayList LA;
        private int nVertices;
        

        public GrafoLA()
        {     
            
            this.LA = new ArrayList();

            return;
        }

        public int Ordem()
        {
            int ordem;
            ordem = LA.Count;

            return ordem;
        }
        public bool InserirVertice(int vertice)
        {
            
            KeyValuePair<int, List<int>> v = new KeyValuePair<int, List<int>>(vertice, new List<int>());
            if (this.LA.Contains(v))
            {
                return true;
            }
            else
            {
                this.LA.Add(v);
                return false;
            }
            
            
        }
        public bool RemoverVertice(int vertice)
        {
            KeyValuePair<int, List<int>> v = new KeyValuePair<int, List<int>>(vertice, new List<int>());
            if (this.LA.Contains(v))
            {
                LA.Remove(v);
                return false;
            }
            else
            {
                return true;
            }
            
        }
        public bool InserirAresta(int v1, int v2)
        {
            foreach(KeyValuePair<int, List<int>> v in this.LA)
            {
                if(v.Key == v1)
                {
                    v.Value.Add(v2);
                    return true;

                }
                else
                {
                    return false;
                }
              
            }
            return false;
        }
        public bool RemoverAresta(int v1, int v2)
        {
            foreach (KeyValuePair<int, List<int>> v in this.LA)
            {
                if (v.Key == v1)
                {
                    v.Value.Remove(v2);
                    return true;

                }
                else if (v.Key == v2)
                {
                    v.Value.Remove(v1);
                    return true;
                }
                else
                {
                    return false;
                }

            }
            return false;
        }
        public int Grau(int vertice)
        {
            foreach (KeyValuePair<int, List<int>> v in this.LA)
            {
                if (v.Key == vertice)
                {
                    return v.Value.Count;
                }
     
            }

            return -1;
        }
        public bool Completo()
        {
            bool completo;
            completo = true;

            int aux;
            aux = LA.Count - 1;

            foreach (KeyValuePair<int, List<int>> v in this.LA)
            {
                if(v.Value.Count != aux)
                {
                    completo = false;
                }
            }

            return completo;
        }
        public bool Regular()
        {
            bool completo;
            completo = true;

            int aux;
            

            foreach (KeyValuePair<int, List<int>> v in this.LA)
            {
                aux = v.Value.Count;
                if (v.Value.Count != aux)
                {
                    completo = false;
                }
            }

            return completo;
            
        }
        public void ShowLA()
        {
            return;
        }
        public void SequenciaGraus()
        {
            return;
        }
        public void VerticesAdjacentes(int vertice)
        {
            foreach (KeyValuePair<int, List<int>> v in this.LA)
            {
                if(v.Key == vertice)
                {
                    Console.WriteLine(v.Value);
                }
            }
               
        }
        public bool Isolado(int vertice)
        {
            int nGrau = 1;
            foreach (KeyValuePair<int, List<int>> v in this.LA)
            {
                if (v.Key == vertice)
                {
                    nGrau = v.Value.Count;
                }
                if(nGrau == 0)
                {
                    return true;
                }
            }
            
            return false;
            
        }
        public bool Impar(int vertice)
        {
            int nGrau = 1;
            foreach (KeyValuePair<int, List<int>> v in this.LA)
            {
                if (v.Key == vertice)
                {
                    nGrau = v.Value.Count;
                }
                if (nGrau % 2 != 0)
                {
                    return true;
                }
            }

            return false;
           
        }
        public bool Par(int vertice)
        {
            int nGrau = 1;
            foreach (KeyValuePair<int, List<int>> v in this.LA)
            {
                if (v.Key == vertice)
                {
                    nGrau = v.Value.Count;
                }
                if (nGrau % 2 == 0)
                {
                    return true;
                }
            }

            return false;
        }
        public bool Adjacentes(int v1, int v2)
        {

            return true;
        }

    }
}
