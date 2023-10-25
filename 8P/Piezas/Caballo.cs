using _8P.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8P.Piezas
{
    public class Caballo : IPieza
    {
        public string nombrePieza = "Caballo";
        public int tamaño = 8;
        public bool PosicOk(int f, int c, Disposicion[][] tabJuego)
        {
            /* Verifico que la posic este dentro del tablero de juego*/
            if (f >= 0 && f < tamaño && c >= 0 && c < tamaño)
            {
                /* Verifico si hay un Pieza Caballo*/
                if (tabJuego[f][c] != Disposicion.P)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
