using ProyectoListas;
using System.Security.Authentication;

namespace Programa_Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selMenu;
            Lista lista = new Lista();
            
            do
            {
                Console.Write("MENU LISTA\r\n---------------------------------\r\n1.- Insertar Nodo\r\n2.- Imprimir Tamaño\r\n3.- Buscar Nodo\r\n4.- Borrar Nodo\r\n5.- Modificar Nodo\r\n6.- Buscar Valor\r\n7.- Imprimir Lista\r\n8.- Salir\r\n_____________________\r\nSelecciónar Opción => ");
                selMenu = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch(selMenu)
                {
                    case 1:

                        int opcion = 0;

                        /* Ciclo para que el usuario elija cuantos numeros quiere en el nodo */
                        do
                        {

                            /* Asignacion de valores para la lista */
                            Console.WriteLine("Dame un numero");
                            int num = int.Parse(Console.ReadLine()!);

                            lista.Add(num);

                            Console.Write("¿Deseas agregar otro número? 1[SI], 2[NO]: ");
                            opcion = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                        }
                        while (opcion != 2);
                    break;

                    case 2:

                        int tamano = lista.Count();

                        Console.WriteLine($"la lista tiene {tamano} nodo(s)");
                        Console.WriteLine();

                    break;

                    case 3:

                        Console.Write("Selecciona la posicion del nodo que buscas: ");
                        int pos = Convert.ToInt32(Console.ReadLine());

                        int valor = lista.Find(pos);

                        if (valor == -1)
                            Console.WriteLine("No se encontro nada en la posicion que elegiste");
                        else
                            Console.WriteLine($"El valor de la posicion {pos} es: {valor}");

                    break;

                    case 4:

                        Console.Write("Ingresa la posición del nodo que deseas borrar: ");
                        int posBorrar = Convert.ToInt32(Console.ReadLine());

                        bool eliminado = lista.Delete(posBorrar);
                        if (eliminado)
                        {
                            Console.WriteLine();
                            Console.WriteLine("El nodo fue eliminado exitosamente.");
                            Console.WriteLine();
                        }

                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("No se encontró la posición indicada.");
                            Console.WriteLine();
                        }

                    break;

                    case 5:

                        Console.WriteLine("ingresa la posicion para modificar el nodo");
                        int posMod = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ingresa el nuevo valor al nodo");
                        int nuevoValor = Convert.ToInt32(Console.ReadLine());

                        bool cambioCorrecto = lista.Change(posMod, nuevoValor);
                        if (cambioCorrecto)
                            Console.WriteLine("El nodo fue modificado correctamente");
                        else
                            Console.WriteLine("La posicion no se encontro");

                    break;

                    case 6:

                        Console.Write("Selecciona el valor que buscas: ");
                        int pos1 = Convert.ToInt32(Console.ReadLine());

                        int posValor = lista.FindValue(pos1);

                        if (posValor == -1)
                            Console.WriteLine("No se encontro ningun valor en la lista");
                        else
                            Console.WriteLine($"El valor {pos1} esta en la posicion {posValor}");

                    break;

                    case 7:

                        lista.Print();
                        Console.WriteLine();

                    break;

                    case 8:

                        Console.WriteLine("ADIOOOOS :D");

                    break;

                    default:

                        Console.WriteLine("ingresa un numero valido porfavor");
                        Console.WriteLine();
                    break;

                }
            }
            while (selMenu != 8);

            Console.ReadLine();
        }
    }
}