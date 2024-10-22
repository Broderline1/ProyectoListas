using System.Drawing;
using System.Reflection.Metadata;

namespace ProyectoListas
{
    public class Lista
    {
        Nodo inicio;

        public Lista()
        {
            inicio = null;
        }

        public void Add(int num)
        {
            Nodo nuevo = new Nodo(num);
            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                Nodo act = inicio;
                while (act.Sig != null)
                    act = act.Sig;
                act.Sig = nuevo;
            }
        }

        public void Print()
        {
            if (inicio == null)
                Console.WriteLine("Esta lista esta vacia");
            else
            {
                Nodo act;
                act = inicio;
                while (act != null)
                {
                    Console.Write($"{act.Valor} ->");
                    act = act.Sig;
                    
                }
            }
            Console.WriteLine();
        }

        public int Find(int pos)
        {
            /* Valida si la lista esa vacia, si lo esta retorna un -1 */
            if (inicio == null || pos < 0)  
                return -1;

            Nodo act = inicio;  

            int contador = 0;

           
            while (act != null)
            {
                if (contador == pos) 
                    return act.Valor;

                act = act.Sig;  
                contador++;
            }

            return -1;  
        }

        public int Count()
        {
            /* Regresa la cantidad de nodos de la lista */

            int contador = 0;
            Nodo act = inicio;  

            while (act != null)
            {
                contador++;  
                act = act.Sig;  
            }

            return contador;  
        }

        public int FindValue(int valor)
        {
            /* Regresa el valor que tiene el valor indicado
             * si no encuentra el valor o la lista esta vacia 
             * regresa -1
             */

            /* Validacion */
            if (inicio == null)
                return -1;

            Nodo act = inicio;
            int posicion = 0;

            /* Recorrido de la lista */
            while (act != null)
            {
                if (act.Valor == valor)  
                    return posicion;

                act = act.Sig;
                posicion++;
            }

            return -1;  

        }

        public bool Change(int pos, int num)
        {
            /* Asigna el nuevo valor en la posicion indicada 
             * si el cambio es exitoso regresa true, 
             * si no encuentra el nodo, o la lista esta vacia
             * regresa false
             */

            if (inicio == null || pos < 0)
                return false;

            Nodo act = inicio;
            int contador = 0;

            while (act != null)
            {
                if(contador == pos)
                {
                    act.Valor = num;
                    return true;

                }

                act = act.Sig;
                contador++;
            }

            return false;

        }

        public bool Delete(int pos)
        {
            if (inicio == null || pos < 0)
                Console.WriteLine("La lista esta vacia");

            if(pos == 0)
            {
                inicio = inicio.Sig;

                return true;
            }

            Nodo act = inicio;
            int contador = 0;

            while (act != null && contador < pos -1)
            {
                act = act.Sig; 
                contador++;
            }

            if (act == null && act.Sig == null)
                return false;

            act.Sig = act.Sig.Sig;

            return true;
        }
    }
}