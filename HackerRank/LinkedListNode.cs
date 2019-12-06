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
        public SinglyLinkedListNode head;
        public int Count
        {
            get
            {
                int counter = 0;
                SinglyLinkedListNode current = this.head;
                if (this.head == null)
                {
                    return counter;
                }

                counter++;
                while(current.next != null)
                {
                    counter++;
                    current = current.next;
                }
                return counter;
            }
        }

        public void DeleteNode(int index)
        {
            if(this.Count == 0)
            {
                Console.WriteLine("No nodes in this list to delete.");
            }
            else if(index < 1)
            {
                Console.WriteLine("Cannot delete index of less than zero");
            }
            else if(index > this.Count)
            {
                Console.WriteLine("List count is currently less than index");
            }
            else
            {
                SinglyLinkedListNode current = this.head;
                while(index > 0)
                {
                    if(index == 1)
                    {
                        //check that we arent at the end of the list
                        if(current.next.next == null)
                        {
                            current.next = null;
                        }
                        else
                        {
                            current.next = current.next.next;
                           
                        }
                        break;
                    }
                    else
                    {
                        current = current.next;
                        index--;
                    }
                }
            }
        }
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

        public SinglyLinkedList()
        {
            this.head = null;
        }

    }
    

    public class LinkedListNodeTest
    {

    }
}
