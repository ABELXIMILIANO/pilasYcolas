using System;

internal class LinkListPila
{
	Nodo cima;
	public LinkListPila()
	{
		this.cima = null;
	}

	internal void CargarPila(int valor)             //Agrega un elemento a la pila y este queda en la cima próximo a salir
    {
		Nodo nuevoNodo = new Nodo(valor);       

        if (cima == null)                           //Si la pila está vacía el nodo no tiene nodo siguiente
        {
			nuevoNodo.siguiente = null;
        }
        else                                //Si la pila tiene elementos agrega el nuevo nodo y coloca el anterior como siguiente en la pila 
        {
            nuevoNodo.siguiente = cima;
        }

        cima = nuevoNodo;                   //El nuevo nodo pasa a ocupar su lugar en la cima de la pila

        Console.WriteLine(valor + " agregado a la pila.");

    }

    internal void DescargarPila()                //Extrae el dato de la cima de la pila, lo muestra y pone la cima en el elemento siguiente
    {
        if (cima == null)
        {
            Console.WriteLine("La pila está vacía.");   //Si la pila está vacía muestra en consola y sale del método
            return;
        }

        Console.WriteLine("Elemento saliente: " + cima.dato);
        cima = cima.siguiente;
    }


    internal void VerCima()                 //Muestra el valor de la cima de la pila
    {
        if (cima == null)                   
        {
            Console.WriteLine("Pila vacía.");   //Si la pila está vacía muestra en consola y sale del método
            return;
        }

        Console.WriteLine(this.cima.dato + " está en la cima de la pila");
    }


}
