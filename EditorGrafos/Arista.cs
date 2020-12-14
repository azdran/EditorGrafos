using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InputKey;

namespace EditorGrafos
{
    public class Arista
    {
        int origen;
        int destino;
        int peso;
        int tipo;//con direccion o sin direccion

        public void llenaArista(int ori, int des, int pes, int tip)
        {
            origen = ori;
            destino = des;
            peso = Convert.ToInt32(InputDialog.mostrar("Cual es el peso de la Arista?"));
            tipo = tip;
        }

        public int getOrigen()
        {
            return origen;
        }

        public int getDestino()
        {
            return destino;
        }

        public int getPeso()
        {
            
            return peso;
        }

        public int getTipo()
        {
            return tipo;
        }

        }
}
