using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructura_1
{
    internal class Nodo
    {

        public string Pnombrem, Pnombred, Pdireccion,Praza;
        public int Pedad,Ptelefono;
        private Nodo siguiente;
        internal Nodo Siguiente
        {
            get => siguiente; set => siguiente = value;
        }
        public Nodo(string Pnomd, string Pdic, int Ptele ,string Pnomm, string Pra, int Ped)
        {
            Pnombrem = Pnomm;
            Pnombred = Pnomd;
            Pdireccion = Pdic; 
            Praza = Pra;
            Pedad = Ped;
            Ptelefono = Ptele;
              
            siguiente = null;
        }
    }
}
