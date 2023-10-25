using _8P.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8P.Ejecucion
{
    public class Ejec 
    { 
        public IPieza nombrePieza;
        public int tamaño = 8;
        public Disposicion[][] tabJuego;

        public Ejec(IPieza pieza)
        {

            nombrePieza = pieza;
            tabJuego = new Disposicion[tamaño][];
            for (int i = 0; i < tamaño; i++)
            {
                tabJuego[i] = new Disposicion[tamaño];
            }
        }

        public bool nuevaEjec()
        {
            return PosicionarReina(0);
        }

        public bool PosicionarReina(int f)
        {
            if (f == tamaño)
            {

                return true;
            }

            for (int c = 0; c < tamaño; c++)
            {
                if (nombrePieza.PosicOk(f, c, tabJuego))
                {

                    tabJuego[f][c] = Disposicion.P;

                    if (PosicionarReina(f + 1))
                    {
                        return true;
                    }

                    tabJuego[f][c] = Disposicion.D;
                }
            }

            return false;
        }
        public void ImprimirTablero()
        {
            Console.WriteLine();
            for (int f = 0; f < tamaño; f++)
            {
                for (int c = 0; c < tamaño; c++)
                {
                    Console.Write(" ");
                    Console.Write(" " + tabJuego[f][c]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
         }
    }
}
