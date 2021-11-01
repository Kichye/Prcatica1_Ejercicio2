using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class ListAl
    {
        Nodo _inicio;
        public void EnlistarAleatorio(int cantidad)
        {
            int maxitems = cantidad;

            while (maxitems != 0)
            {
                Nodo unNuevoNodo = new Nodo();
                if (_inicio == null)
                {

                    Random rnd = new Random();

                    unNuevoNodo.Valor = rnd.Next(1, 100);
                    _inicio = unNuevoNodo;
                    maxitems = maxitems - 1;
                }
                else
                {
                    Nodo aux = BuscarLast(_inicio);

                    Random rnd = new Random();

                    unNuevoNodo.Valor = rnd.Next(1, 100);

                    aux.next = unNuevoNodo;
                    maxitems = maxitems - 1;

                }
            }
        }

        private Nodo BuscarLast(Nodo unNodo)
        {
            if (unNodo.next == null)
            {
                return unNodo;
            }
            else
            {
                return BuscarLast(unNodo.next);
            }
        }
        public Nodo Inicio
        {
            get
            {
                return _inicio;
            }
        }

        public bool Vacia()
        {
            return (_inicio == null);
        }

    }
}
