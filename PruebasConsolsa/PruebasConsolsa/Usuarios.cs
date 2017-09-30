using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasConsolsa
{
    class Usuarios<E>
    {

        public static int CAPACITY = 9;
        private E[] data;
        private int tamanio = 0;

        public Usuarios()
        {
            data = new E[CAPACITY];
        }

        public int size()
        {
            return tamanio;
        }

        public bool isEmpty()
        {
            return tamanio == 0;
        }

        public E get(int i)
        {
            return data[i];
        }

        public E set(int i, E e)
        {
            E temp = data[i];
            data[i] = e;
            return temp;
        }

        public void add(int i, E e)
        {
            if (tamanio < data.Length)
            {
                for (int k = tamanio - 1; k >= i; k--)
                {// start by shifting rightmost
                    data[k + 1] = data[k];
                    data[i] = e; // ready to place the new element size++;
                }
            }

        }

        public E remove(int i)
        {

            E temp = data[i];
            for (int k = i; k < (tamanio - 1); k++)
            {
                data[k] = data[k + 1];
                data[tamanio - 1] = default(E);
            }
            tamanio--;
            return temp;
        }
    }

}
