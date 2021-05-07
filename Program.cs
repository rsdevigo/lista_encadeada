using System;

namespace lista_encadeada
{
  class Program
  {
    static void Main(string[] args)
    {
      MyList myList = new MyList();
      myList.Add(10);
      myList.Add(20);
      myList.Add(3);
      myList.PrintList();
    }
  }
}
