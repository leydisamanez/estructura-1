using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructura_1
{
    internal class Lista
    {
        Nodo Pprimero;
        public Nodo Praiz;
        public Lista()
        {
            Pprimero = null;
        }
        public void insertar(string Pnombred, string Pdireccion, int Ptelefono, string Pnombrem, string Praza, int Pedad)
        {
            if (Pprimero == null)
            {
                Pprimero = new Nodo(Pnombred, Pdireccion, Ptelefono, Pnombrem, Praza, Pedad);
                Praiz = Pprimero;
            }
            else
            {
                Nodo nuevo = new Nodo(Pnombred, Pdireccion , Ptelefono, Pnombrem, Praza, Pedad);
                Pprimero.Siguiente = nuevo;
                Pprimero = nuevo;
            }
        }

        public void desplegarm(DataGridView data)
        {
            Nodo actual;
            actual = Praiz;
            data.Rows.Clear();
            while (actual != null)
            {
                data.Rows.Add(actual.Pnombrem, actual.Praza, actual.Pedad);
                actual = actual.Siguiente;
            }
        }
        public void desplegard(DataGridView data)
        {
            Nodo actual;
            actual = Praiz;
            data.Rows.Clear();
            while (actual != null)
            {
                data.Rows.Add(actual.Pnombred, actual.Pdireccion, actual.Ptelefono);
                actual = actual.Siguiente;
            }
        }

        public void buscar(string nom, DataGridView data)
        {
            Nodo actual = Praiz;
            while (actual.Pnombrem != nom)
                actual = actual.Siguiente;
            data.Rows.Clear();
            data.Rows.Add(actual.Pnombrem, actual.Praza, actual.Pedad);
          
        }
    }
}
