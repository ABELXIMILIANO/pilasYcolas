using System;

internal class Nodo
{
	internal int dato;
	internal Nodo siguiente;                //Los nodos tienen una referencia al nodo siguiente

    public Nodo(int dato)
    {
        this.dato = dato;                   
		siguiente = null;                   
    }


}
