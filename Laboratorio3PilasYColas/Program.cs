using System;

namespace Laboratorio3PilasYColas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            String respuesta;
            int valor;
            int accion;
            LinkListCola cola = new LinkListCola();
            LinkListPila pila = new LinkListPila();

            do
            {
                Console.WriteLine("Desea trabajar los elementos como cola(C) o como pila(P)"); //Se elige si trabajar con pilas o con colas
                respuesta = Console.ReadLine().ToUpper();
            } while (!(respuesta.Equals("C")||respuesta.Equals("P")));

            if (respuesta.Equals("C"))      // Trabajo con colas
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Ingrese 1 para cargar un elemento y 2 para eliminar un elemento (0 para salir)");
                        accion = Int32.Parse(Console.ReadLine());
                        if (accion==1)  
                        {
                            Console.WriteLine("Ingrese el valor (como entero) del elemento");
                            valor = Int32.Parse(Console.ReadLine());
                            cola.PonerEnCola(valor);    //Con este método se agrega un nodo a la cola
                        }
                        if (accion == 2)
                        {
                            cola.SacarDeCola();         //Con este método se quita el elemento de la cabeza de la cola
                        }
                    }
                    catch (Exception e)                 //Excepción cuando se ingresa algo que no es un entero
                    {
                        Console.WriteLine(e.Message);
                        throw;
                    }
                } while (accion!=0);
            }


            if (respuesta.Equals("P"))          //Trabajo con pilas
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Ingrese 1 para cargar un elemento, 2 para eliminar un elemento y 3 para ver la cima de la pila (0 para salir)");
                        accion = Int32.Parse(Console.ReadLine());
                        if (accion == 1)
                        {
                            Console.WriteLine("Ingrese el valor (como entero) del elemento");
                            valor = Int32.Parse(Console.ReadLine());
                            pila.CargarPila(valor);     //Método para cargar pila
                        }
                        if (accion == 2)
                        {
                            pila.DescargarPila();       //Método para sacar el elemento de la cima de la pila
                        }
                        if (accion == 3)
                        {
                            pila.VerCima();             // Método para ver el elemento de la cima de la pila
                        }
                    }
                    catch (Exception e)     //Excepción cuando se ingresa algo que no es un entero
                    {
                        Console.WriteLine(e.Message);
                        throw;
                    }
                } while (accion != 0);
            }
        }
    }
}
