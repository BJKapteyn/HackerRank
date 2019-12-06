using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
   
        
    class SinglyLinkedListNode
    {
        public int? data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    class SinglyLinkedList
    {
        public void PrintList()
        {
            Console.WriteLine(this.head.data);
            SinglyLinkedListNode current = head;
            while(current.next != null)
            {
                Console.WriteLine(current.next.data);
                current = current.next;
            }
            Console.ReadKey();
        }
        public SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
        {

            SinglyLinkedListNode result = new SinglyLinkedListNode(data);
            SinglyLinkedListNode current = head;
            if(current == null)
            {
                this.head = result;
            }
            else
            {

                while(current.next != null)
                {
                    current = current.next;
                }
                current.next = result;
            }

            return result;

        }
        public SinglyLinkedListNode head;

        public SinglyLinkedList()
        {
            this.head = null;
        }

    }
    

    public class LinkedListNodeTest
    {

    }
}
