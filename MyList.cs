using System;
using System.Collections;
namespace lista_encadeada
{
  class MyList : IEnumerable
  {
    protected int numberOfElements;
    protected Node head;
    protected Node tail;
    public MyList()
    {
      numberOfElements = 0;
      head = null;
      tail = null;
    }

    public void Add(int x)
    {
      Node newNode = new Node(x);
      if (numberOfElements == 0)
      {
        head = tail = newNode;
      }
      else
      {
        tail.next = newNode;
        newNode.prev = tail;
        tail = newNode;
      }
      numberOfElements++;
    }

    public void PrintList()
    {
      Node currentNode = head;
      while (currentNode != null)
      {
        Console.WriteLine(currentNode.value);
        currentNode = currentNode.next;
      }
    }

    /*
    Método recebe um inteiro x e retorna o primeiro Nó da lista 
    que contém o valor x
    */
    public Node Search(int x)
    {
      return null;
    }

    /*
    Método recebe um inteiro x, remove o primeiro Nó
    que contém o valor x e retorna uma referência deste nó
    */
    public Node Remove(int x)
    {
      return null;
    }

    public IEnumerator GetEnumerator()
    {
      Node currentNode = head;
      while (currentNode != null)
      {
        yield return currentNode;
        currentNode = currentNode.next;
      }
    }
  }
}