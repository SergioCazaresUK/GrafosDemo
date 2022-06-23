using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public class CantGrafos
    {
        int[,] Adyacencia;
        int[] indegree;
        int nodo;

        public CantGrafos(int Nodos)
        {
            nodo = Nodos;
            Adyacencia = new int[nodo, nodo];

            indegree = new int[nodo];
        }

        public void Arista(int NodoInicio, int NodoFinal)
        {
            Adyacencia [NodoInicio, NodoFinal] = 1;
        }

        public void MuestraAdyacencia()
        {
            int n = 1;
            int m = 1;

            Console.ForegroundColor = ConsoleColor.Yellow;

            for (n = 1; n < nodo; n++)
                Console.WriteLine(n);

            Console.WriteLine();

            for(n = 1; n < nodo; n++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(n);
                for(m = 1; m < nodo; m++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Adyacencia[n, m]);
                }
                Console.WriteLine();
            }
        }
    }
}
