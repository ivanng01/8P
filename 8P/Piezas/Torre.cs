using _8P.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8P.Piezas
{
    public class Torre : IPieza
    {
        public string nombrePieza = "Torre";
        public int tamaño = 8;
        public bool PosicOk(int f, int c, Disposicion[][] tabJuego)
        {

            for (int i = 0; i < f; i++)
            {
                /* Controlo si hay una R en la misma c del tablero*/
                if (tabJuego[i][c] == Disposicion.P)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
