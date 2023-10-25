using _8P.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8P.Piezas
{
    public class Reina : IPieza
    {
        public string nombrePieza = "Reina";
        public int tamaño = 8;

        public bool PosicOk(int f, int c, Disposicion[][] tabJuego)
        {
            for (int i = 0; i < f; i++)
            {
                /* Compruebo si ya hay una reina en la misma c */
                if (tabJuego[i][c] == Disposicion.P)
                {
                    return false;
                }

                /* Compruebo D*/
                // Verificar diagonal superior izquierda
                if (c - (f - i) >= 0 && tabJuego[i][c - (f - i)] == Disposicion.P)
                {
                    return false;
                }

                /* Compruebo D*/
                if (c + (f - i) < tamaño && tabJuego[i][c + (f - i)] == Disposicion.P)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
