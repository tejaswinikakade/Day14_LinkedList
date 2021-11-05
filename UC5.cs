using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureDemo
{
    class UC5
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
        public int DeleteFirstNode()
        {
            if (this.head == null)
            {
                return 0;
            }
            int deleteNode = this.head.data;
            this.head = this.head.next;
            return deleteNode;
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
