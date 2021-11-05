using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureDemo
{
    class UC8
    
    {
        public Node head;
        public void InsertLast(int new_data)
        {
            Node new_node = new Node(new_data);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = new_node;
            }
            Console.WriteLine("Inserted into list:" + new_node.data);
        }

        //method for getting the last node
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        //method to find and insert after that
        public void FindAndInsert(Node exist_node, int new_data)
        {
            if (exist_node == null)
            {
                Console.WriteLine("This node not exist in list");
                return;
            }
            Node new_node = new Node(new_data);
            new_node.next = exist_node.next;
            exist_node.next = new_node;
        }
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
