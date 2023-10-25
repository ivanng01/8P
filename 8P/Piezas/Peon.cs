using _8P.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8P.Piezas
{
    public class Peon : IPieza
    {

        public string nombrePieza = "Peon";
        public int tamaño = 8;
        public bool PosicOk(int f, int c, Disposicion[][] tabJuego)
        {

            for (int i = 0; i < f; i++)
            {
                /* Verifico DSI*/
                if (c - (f - i) >= 0 && tabJuego[i][c - (f - i)] == Disposicion.P)
                {
                    return false;
                }

                /* Verifico DSD*/
                if (c + (f - i) < tamaño && tabJuego[i][c + (f - i)] == Disposicion.P)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
