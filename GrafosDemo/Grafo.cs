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
        int nodo;

        public CantGrafos(int Nodos)
        {
            nodo = Nodos;
            Adyacencia = new int[nodo, nodo];
        }

        public void Arista(int NodoInicio, int NodoFinal)
        {
            Adyacencia [NodoInicio, NodoFinal] = 1;
        }

        public void MuestraAdyacencia()
        {
            int Columnas = 1;
            int Filas = 1;

            Console.ForegroundColor = ConsoleColor.Yellow;

            for (Columnas = 1; Columnas < nodo; Columnas++)
                Console.WriteLine("\t{0}", Columnas);

            Console.WriteLine();

            for(Columnas = 1; Columnas < nodo; Columnas++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Columnas);

                for(Filas = 1; Filas < nodo; Filas++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t{0}", Adyacencia[Columnas, Filas]);
                }
                Console.WriteLine();
            }
        }
    }
}
