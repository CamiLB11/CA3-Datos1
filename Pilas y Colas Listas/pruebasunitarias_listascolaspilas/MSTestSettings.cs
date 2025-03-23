using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PilaListaTests
{
    [TestMethod]
    public void Push_AddsElementToStack()
    {
        var pila = new Pila_lista();
        pila.push(10);
        Assert.AreEqual(10, pila.Top());
    }

    [TestMethod]
    public void Pop_RemovesTopElement()
    {
        var pila = new Pila_lista();
        pila.push(10);
        pila.push(20);
        pila.pop();
        Assert.AreEqual(10, pila.Top());
    }

    [TestMethod]
    public void Top_ReturnsMinusOne_WhenStackIsEmpty()
    {
        var pila = new Pila_lista();
        Assert.AreEqual(-1, pila.Top());
    }
}

[TestClass]
public class ColaListaTests
{
    [TestMethod]
    public void Enqueue_AddsElementToQueue()
    {
        var cola = new cola_Lista();
        cola.enqueue(10);
        Assert.AreEqual(10, cola.Front());
        Assert.AreEqual(10, cola.Rear());
    }

    [TestMethod]
    public void Dequeue_RemovesFrontElement()
    {
        var cola = new cola_Lista();
        cola.enqueue(10);
        cola.enqueue(20);
        int removed = cola.dequeue();
        Assert.AreEqual(10, removed);
        Assert.AreEqual(20, cola.Front());
    }

    [TestMethod]
    public void Dequeue_ReturnsMinusOne_WhenQueueIsEmpty()
    {
        var cola = new cola_Lista();
        Assert.AreEqual(-1, cola.dequeue());
    }

    [TestMethod]
    public void Front_ReturnsMinusOne_WhenQueueIsEmpty()
    {
        var cola = new cola_Lista();
        Assert.AreEqual(-1, cola.Front());
    }
}
