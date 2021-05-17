using System;
using System.Collections;
namespace lista_encadeada
{
  class Node
  {
    public int value;
    public Node next;
    public Node prev;
    public Node(int x)
    {
      this.value = x;
      this.next = null;
      this.prev = null;
    }
  }
}