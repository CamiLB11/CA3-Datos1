using System;

public interface pila
{
    void push(int dato);
    void pop();
    int Top();
}

public class Node
{
    public int dato { get; set; }
    public Node next { get; set; }

    public Node(int dato)
    {
        this.dato = dato;
        this.next = null;
    }
}

public class Pila_lista : pila
{
    public Node top;

    public void push(int dato)
    {
        Node nuevo = new Node(dato);
        nuevo.next = top;
        top = nuevo;
    }

    public void pop()
    {
        if (top == null)
        {
            Console.WriteLine("La pila está vacía");
        }
        else
        {
            top = top.next;
        }
    }

    public int Top()
    {
        if (top == null)
        {
            Console.WriteLine("La pila está vacía");
            return -1;
        }
        else
        {
            return top.dato;
        }
    }
}

public class cola_Lista
{
    public Node front;
    public Node rear;

    public cola_Lista()
    {
        front = null;
        rear = null;
    }

    public void enqueue(int dato)
    {
        Node nuevo = new Node(dato);

        if (rear == null)
        {
            front = nuevo;
            rear = nuevo;
        }
        else
        {
            rear.next = nuevo;
            rear = nuevo;
        }
    }

    public int dequeue()
    {
        if (front == null)
        {
            Console.WriteLine("La cola está vacía");
            return -1;
        }
        else
        {
            int dato = front.dato;
            front = front.next;

            if (front == null)
            {
                rear = null;
            }

            return dato;
        }
    }

    public int Front()
    {
        if (front == null)
        {
            Console.WriteLine("La cola está vacía");
            return -1;
        }
        else
        {
            return front.dato;
        }
    }

    public int Rear()
    {
        if (rear == null)
        {
            Console.WriteLine("La cola está vacía");
            return -1;
        }
        else
        {
            return rear.dato;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        cola_Lista cola = new cola_Lista();

        // Agregar elementos a la cola
        Console.WriteLine("Agregando elementos a la cola:");
        cola.enqueue(1);
        Console.WriteLine($"Elemento agregado: 1, Front: {cola.Front()}, Rear: {cola.Rear()}");
        cola.enqueue(2);
        Console.WriteLine($"Elemento agregado: 2, Front: {cola.Front()}, Rear: {cola.Rear()}");
        cola.enqueue(3);
        Console.WriteLine($"Elemento agregado: 3, Front: {cola.Front()}, Rear: {cola.Rear()}");
        cola.enqueue(4);
        Console.WriteLine($"Elemento agregado: 4, Front: {cola.Front()}, Rear: {cola.Rear()}");
        cola.enqueue(5);
        Console.WriteLine($"Elemento agregado: 5, Front: {cola.Front()}, Rear: {cola.Rear()}");

        // Eliminar elementos de la cola
        Console.WriteLine("\nEliminando elementos de la cola:");
        Console.WriteLine($"Elemento eliminado: {cola.dequeue()}, Front: {cola.Front()}, Rear: {cola.Rear()}");
        Console.WriteLine($"Elemento eliminado: {cola.dequeue()}, Front: {cola.Front()}, Rear: {cola.Rear()}");
        Console.WriteLine($"Elemento eliminado: {cola.dequeue()}, Front: {cola.Front()}, Rear: {cola.Rear()}");

        // Mostrar el elemento frontal y trasero actual
        Console.WriteLine("\nEstado actual de la cola:");
        Console.WriteLine($"Front: {cola.Front()}, Rear: {cola.Rear()}");

        // Eliminar todos los elementos restantes
        Console.WriteLine("\nEliminando todos los elementos restantes:");
        Console.WriteLine($"Elemento eliminado: {cola.dequeue()}, Front: {cola.Front()}, Rear: {cola.Rear()}");
        Console.WriteLine($"Elemento eliminado: {cola.dequeue()}, Front: {cola.Front()}, Rear: {cola.Rear()}");

        // Intentar eliminar de una cola vacía
        Console.WriteLine("\nIntentando eliminar de una cola vacía:");
        cola.dequeue();
    }
}