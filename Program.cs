using System;

namespace lista_encadeada
{
  class Program
  {
    static void Main(string[] args)
    {
      // Queue myList = new Queue();
      // myList.Push(10);
      // myList.Push(20);
      // myList.Push(3);
      // myList.PrintList();
      // Node n = myList.Pop();
      // while (n != null)
      // {
      //   Console.WriteLine(n.value);
      //   n = myList.Pop();
      // }
      MazeMaker.buildMaze(4, 3);
    }
  }
}
