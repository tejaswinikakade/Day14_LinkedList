using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureDemo
{
    class UC4
    {
        public Node head;
        //creating method for inserting elements at last
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
        //method for Insert at middle of a linked list
        public void InsertMid(int new_data)
        {
            Node new_node = new Node(new_data);
            Node pos = head;
            int len = 0;
            //calculate the length of linked list
            while (pos != null)
            {
                len++;
                pos = pos.next;
            }
            //finding middle possition
            int count = ((len % 2) == 0) ? (len / 2) : (len + 1) / 2;
            pos = head;
            //pos is the pointer to the node after which the new node to be insert
            while (count-- > 1)
            {
                pos = pos.next;
            }
            new_node.next = pos.next;
            pos.next = new_node;
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
