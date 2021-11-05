using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureDemo
{
    class UC2
    {
        public Node head;
        public void InsertFront(int new_data)
        {
           
            Node new_node = new Node(new_data);
            new_node.next = this.head;
            this.head = new_node;
            Console.WriteLine("Inserted into list" + new_node.data);
        }

        //method for displaying elements in linked list
        public void Display()
        {
            Console.WriteLine("Displaying Nodes");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(" " + temp.data + " ");
                    temp = temp.next;
                }
            }
        }

    }
}
