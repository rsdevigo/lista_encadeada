using System;
using System.Collections;
namespace lista_encadeada
{
  class Queue : MyList
  {
    public Queue() : base() { }

    public Node Pop()
    {
      if (numberOfElements == 0)
      {
        return null;
      }
      Node ret = head;
      head = head.next;
      numberOfElements--;
      if (numberOfElements != 0)
      {
        head.prev = null;
      }
      return ret;
    }

    public void Push(int x)
    {
      base.Add(x);
    }
  }
}