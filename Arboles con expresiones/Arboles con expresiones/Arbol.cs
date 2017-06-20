using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles_con_expresiones
{
    class Arbol
    {
        private Nodo raiz = null;
        private Nodo inicio;
        private Nodo ultimo;

        public void Agregar(Nodo nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                Agregar(nuevo, inicio);
            }
        }

        private void Agregar(Nodo n, Nodo padre)
        {
            if (padre.siguiente == null)
            {
                padre.siguiente = n;
                n.anterior = padre;
                ultimo = n;
            }
            else
            {
                Agregar(n, padre.siguiente);
            }
        }

        public void ArmarArbol()
        {
            string dato;
            Nodo temp = inicio;
            Nodo anterior = null; 
            Nodo siguiente = null;

            while (temp != null)
            {
                siguiente = temp.siguiente;
                dato = temp.nodo.ToString();

                if (dato == "*" || dato == "/")
                {
                    raiz = temp;
                    temp.hi = temp.anterior;
                    temp.hd = temp.siguiente;
                    Enlazar(temp, anterior, siguiente);
                }

                anterior = temp;
                temp = temp.siguiente;
            }


            temp = inicio;
            anterior = null;
            siguiente = null;

            while (temp != null)
            {
                siguiente = temp.siguiente;
                dato = temp.nodo.ToString();

                if (dato == "+" || dato == "-")
                {
                    raiz = temp;
                    temp.hi = temp.anterior;
                    temp.hd = temp.siguiente;
                    Enlazar(temp, anterior, siguiente);
                }

                anterior = temp;
                temp = temp.siguiente;
            }

            inicio = null;
        }

        private void Enlazar(Nodo n, Nodo anterior, Nodo siguiente)
        {
            if (n.anterior == inicio)
            {
                inicio = inicio.siguiente;
                inicio.anterior = null;
            }
            else
            {
                n.anterior = anterior.anterior;
                anterior.anterior.siguiente = n;
            }

            if (n.siguiente == ultimo)
            {
                ultimo.anterior.siguiente = null;
                ultimo = ultimo.anterior;
            }
            else
            {
                n.siguiente = siguiente.siguiente;
                siguiente.siguiente.anterior = n;
            }
        }

        public string PreOrder()
        {
            string salida = "";

            if (raiz == null)
            {
                return salida;
            }
            else
            {
                return PreOrder(raiz);
            }
        }

        private string PreOrder(Nodo nodo)
        {
            string text = "";

            text += nodo.ToString() + "";
            if (nodo.hi != null)
            {
                text += PreOrder(nodo.hi) + "";
            }
            if (nodo.hd != null)
            {
                text += PreOrder(nodo.hd) + "";
            }
            return text;
        }

        public string PostOrder()
        {
            if (raiz == null)
            {
                return null;
            }
            else
            {
                return PostOrder(raiz);
            }
        }

        private string PostOrder(Nodo nodo)
        {
            string text = "";

            if (nodo.hi != null)
            {
                text += PostOrder(nodo.hi) + "";
            }
            if (nodo.hd != null)
            {
                text += PostOrder(nodo.hd) + "";
            }
            text += nodo.ToString() + "";
            return text;
        }
    }
}

