using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureDemo
{
    class UC10
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
        public void sortList()
        {
            //Node current will point to head  
            Node current = head, index = null;
            int temp;

            if (head == null)
            {
                return;
            }
            else
            {
                while (current != null)
                {
                    //Node index will point to node next to current  
                    index = current.next;

                    while (index != null)
                    {

                        if (current.data > index.data)
                        {
                            temp = current.data;
                            current.data = index.data;
                            index.data = temp;
                        }
                        index = index.next;
                    }
                    current = current.next;
                }
            }
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
