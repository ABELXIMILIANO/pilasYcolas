using System;

public class LinkListCola
{
	Nodo cabeza;	//Primer elemento ingresado y próximo a salir
	Nodo cola;		//Último elemento ingresado a la cola
	public LinkListCola()
	{
		this.cabeza = this.cola = null;
	}

	internal void PonerEnCola(int valor)        //Ingresa un nuevo nodo con un nuevo valor a la cola
    {
		Nodo nuevoNodo = new Nodo(valor);

        if (this.cola == null)                  //Si la cola esta vacía coloca el nuevo nodo como cabeza y cola
        {
			this.cabeza = this.cola = nuevoNodo;
        }
        else
        {                                       
			this.cola.siguiente = nuevoNodo;    //Si la cola tiene elementos agrega el nuevo nodo como siguiente a la antigua cola
            this.cola = nuevoNodo;              // y ubica al nuevo nodo como la cola
        }
    }

	internal void SacarDeCola()                 //Elimina el elemento de la cabeza de la cola
    {
        if (this.cabeza == null)                //Si la cola está vacía muestra en consola y sale del método
        {
            Console.WriteLine("La cola esta vacía");
            return;
        }

        Nodo aux = this.cabeza;                 //Extrae el nodo en la cabeza de la cola para mostrarlo al final
        this.cabeza = this.cabeza.siguiente;    //Ubica el siguiente nodo como cabeza de la cola

        if (this.cabeza == null)                //Si el siguiente nodo no tiene siguiente tambien elimina el valor de cola
        {
            this.cola = null;
        }

        Console.WriteLine("El valor extraído es: " + aux.dato);
    }


}
