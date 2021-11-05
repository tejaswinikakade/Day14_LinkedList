using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureDemo
{
    class UC9
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
        public void DeleteNode(int value)
        {
            //head node stored in temp
            Node temp = head, prev = null;
            //checking the head node holding the value
            if (temp != null && temp.data == value)
            {
                head = temp.next;
            }
            //search for value to delete,also update previous node as temp.next
            while (temp != null && temp.data != value)
            {
                prev = temp;
                temp = temp.next;
            }

            if (temp == null)
            {
                Console.WriteLine("Given node is not present");
            }
            //delete node 
            prev.next = temp.next;
        }
        public int Size()
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
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
