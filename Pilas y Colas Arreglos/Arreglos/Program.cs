using System;

public interface pila
{
    void Push(int dato);
    int Pop(); 
    int Top();
}

public class pila_arreglo : pila
{
    public int[] stack;
    public int top;
    public int size;

    public pila_arreglo(int size)
    {
        this.size = size;
        stack = new int[size];
        top = -1;
    }

    public void Push(int dato)
    {
        if (top == size - 1)
        {
            Console.WriteLine ("No hay espacio");

        }
        else
        {
            stack[++top] = dato;
        }
    }
    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine ("No hay elementos en la pila");
            return -1;
        }
        else
        {
            return stack[top--];
        }
    }
    public int Top()
    {
        if (top == -1)
        {
            Console.WriteLine ("No hay elementos en la pila");
            return -1;
        }
        else
        {
            return stack[top];
        }
    }
    


}

public interface Cola
{
    void Enqueue(int datos);
    int Dequeue();
    int obtener_frente_cola();
}

public class cola_arreglo : Cola
{
    public int[] queue;
    public int frente;
    public int final;
    public int size;

    public cola_arreglo(int size)
    {
        this.size = size;
        queue = new int[size];
        frente = -1;
        final = -1;
    }

    public void Enqueue(int datos)
    {
        if (final == size - 1)
        {
            Console.WriteLine ("No hay espacio");
        }
        else
        {
            if(frente == -1)
            {
                frente = 0;
            }
            queue[++final] = datos;
        }
    }
    public int Dequeue()
    {
        if (frente == -1)
        {
            Console.WriteLine ("No hay elementos en la cola");
            return -1;
        }
        else
        {
            int dato = queue[frente];
            if (frente == final)
            {
                frente = -1;
                final = -1;
            }
            else
            {
                frente++;
            }
            return dato;
        }
    }
    public int obtener_frente_cola()
    {
        if (frente == -1)
        {
            Console.WriteLine ("No hay elementos en la cola");
            return -1;
        }
        else
        {
            return queue[frente];
        }
    }
    
}

public class cola_arreglo_circular : Cola
{
    public int[] queue;
    public int frente;
    public int final;
    public int size;

    public cola_arreglo_circular(int size)
    {
        this.size = size;
        queue = new int[size];
        frente = -1;
        final = -1;
    }

    public void Enqueue(int datos)
    {
        if ((final == size - 1 && frente == 0) || (final + 1 == frente))
        {
            Console.WriteLine ("No hay espacio");
        }
        else
        {
            if(frente == -1)
            {
                frente = 0;
            }
            final = (final + 1) % size;
            queue[final] = datos;
        }
    }
    public int Dequeue()
    {
        if (frente == -1)
        {
            Console.WriteLine ("No hay elementos en la cola");
            return -1;
        }
        else
        {
            int dato = queue[frente];
            if (frente == final)
            {
                frente = -1;
                final = -1;
            }
            else
            {
                frente = (frente + 1) % size;
            }
            return dato;
        }
    }
    public int obtener_frente_cola()
    {
        if (frente == -1)
        {
            Console.WriteLine ("No hay elementos en la cola");
            return -1;
        }
        else
        {
            return queue[frente];
        }
    }
}


class Program
{
    static void Main()
    {
        cola_arreglo_circular cola = new cola_arreglo_circular(5);

        // Agregar elementos a la cola circular
        cola.Enqueue(10);
        cola.Enqueue(20);
        cola.Enqueue(30);

        // Mostrar el elemento al frente de la cola circular
        Console.WriteLine("Frente de la cola circular: " + cola.obtener_frente_cola());

        // Eliminar un elemento de la cola circular
        Console.WriteLine("Elemento eliminado: " + cola.Dequeue());

        // Mostrar el nuevo frente de la cola circular
        Console.WriteLine("Nuevo frente de la cola circular: " + cola.obtener_frente_cola());

        // Agregar más elementos
        cola.Enqueue(40);
        cola.Enqueue(50);

        // Intentar agregar un elemento cuando la cola circular está llena
        cola.Enqueue(60);

        // Eliminar todos los elementos de la cola circular
        while (cola.obtener_frente_cola() != -1)
        {
            Console.WriteLine("Elemento eliminado: " + cola.Dequeue());
        }

        // Intentar eliminar de una cola circular vacía
        Console.WriteLine("Intentar eliminar de una cola vacía: " + cola.Dequeue());
    }
}