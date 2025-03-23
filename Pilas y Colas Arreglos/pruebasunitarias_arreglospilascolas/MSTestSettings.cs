using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PilaArregloTests
{
    [TestMethod]
    public void Push_AddsElementToStack()
    {
        var pila = new pila_arreglo(5);
        pila.Push(10);
        Assert.AreEqual(10, pila.Top());
    }

    [TestMethod]
    public void Pop_RemovesAndReturnsTopElement()
    {
        var pila = new pila_arreglo(5);
        pila.Push(10);
        pila.Push(20);
        Assert.AreEqual(20, pila.Pop());
        Assert.AreEqual(10, pila.Top());
    }

    [TestMethod]
    public void Pop_ReturnsMinusOne_WhenStackIsEmpty()
    {
        var pila = new pila_arreglo(5);
        Assert.AreEqual(-1, pila.Pop());
    }
}

[TestClass]
public class ColaArregloTests
{
    [TestMethod]
    public void Enqueue_AddsElementToQueue()
    {
        var cola = new cola_arreglo(5);
        cola.Enqueue(10);
        Assert.AreEqual(10, cola.obtener_frente_cola());
    }

    [TestMethod]
    public void Dequeue_RemovesAndReturnsFrontElement()
    {
        var cola = new cola_arreglo(5);
        cola.Enqueue(10);
        cola.Enqueue(20);
        Assert.AreEqual(10, cola.Dequeue());
        Assert.AreEqual(20, cola.obtener_frente_cola());
    }

    [TestMethod]
    public void Dequeue_ReturnsMinusOne_WhenQueueIsEmpty()
    {
        var cola = new cola_arreglo(5);
        Assert.AreEqual(-1, cola.Dequeue());
    }
}

[TestClass]
public class ColaArregloCircularTests
{
    [TestMethod]
    public void Enqueue_AddsElementToCircularQueue()
    {
        var cola = new cola_arreglo_circular(5);
        cola.Enqueue(10);
        Assert.AreEqual(10, cola.obtener_frente_cola());
    }

    [TestMethod]
    public void Dequeue_RemovesAndReturnsFrontElement()
    {
        var cola = new cola_arreglo_circular(5);
        cola.Enqueue(10);
        cola.Enqueue(20);
        Assert.AreEqual(10, cola.Dequeue());
        Assert.AreEqual(20, cola.obtener_frente_cola());
    }

    [TestMethod]
    public void Dequeue_ReturnsMinusOne_WhenCircularQueueIsEmpty()
    {
        var cola = new cola_arreglo_circular(5);
        Assert.AreEqual(-1, cola.Dequeue());
    }
}
