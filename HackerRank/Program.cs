using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList L = new SinglyLinkedList();
            L.insertNodeAtTail(L.head, 14);
            L.insertNodeAtTail(L.head, 15);
            L.insertNodeAtTail(L.head, 16);
            L.insertNodeAtTail(L.head, 17);
            L.insertNodeAtTail(L.head, 15);

            L.PrintList();
            L.DeleteNode(1);
            L.PrintList();
            L.DeleteNode(0);
            L.DeleteNode(3);
            L.PrintList();
            
            Console.WriteLine(L.Count);
            Console.ReadKey();
        }
        
    }
    
}
