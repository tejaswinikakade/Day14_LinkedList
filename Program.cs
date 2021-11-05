using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*****uc1******");
            UC1 UC1 = new UC1();
            UC1.InsertLast(56);
            UC1.InsertLast(30);
            UC1.InsertLast(70);
            UC1.Display();
            Console.ReadLine();

            Console.WriteLine("*****uc2******");
            UC2 UC2 = new UC2();
            UC2.InsertFront(70);
            UC2.InsertFront(30);
            UC2.InsertFront(56);
            UC2.Display();
            Console.ReadLine();

            Console.WriteLine("*****uc3******");
            UC3 UC3 = new UC3();
            UC3.Append(56);
            UC3.Append(30);
            UC3.Append(70);
            UC3.Display();
            Console.ReadLine();

            Console.WriteLine("*****uc4******");
            UC4 UC4 = new UC4();
            UC4.InsertLast(56);
            UC4.InsertLast(70);
            Console.WriteLine("Linked list before insertion:");
            UC4.Display();
            UC4.InsertMid(30);
            Console.WriteLine("Linked list after insertion:");
            UC4.Display();
            Console.ReadLine();

            Console.WriteLine("*****uc5******");
            UC5 UC5 = new UC5();
            UC5.InsertLast(56);
            UC5.InsertLast(30);
            UC5.InsertLast(70);
            Console.WriteLine("Linked list before deletion:");
            UC5.Display();
            UC5.DeleteFirstNode();
            Console.WriteLine("Linked list after deletion:");
            UC5.Display();
            Console.ReadLine();

            Console.WriteLine("*****uc6******");
            UC6 UC6 = new UC6();
            UC6.InsertLast(56);
            UC6.InsertLast(30);
            UC6.InsertLast(70);
            Console.WriteLine("Linked list before deletion:");
            UC6.Display();
            UC6.DeleteLastNode();
            Console.WriteLine("Linked list after deletion:");
            UC6.Display();
            Console.ReadLine();

            Console.WriteLine("*****uc7******");
            UC7 UC7 = new UC7();
            UC7.InsertLast(56);
            UC7.InsertLast(30);
            UC7.InsertLast(70);
            Console.WriteLine(UC7.Search(30));
            Console.ReadLine();

            Console.WriteLine("*****uc8******");
            UC8 UC8 = new UC8();
            UC8.InsertLast(56);
            UC8.InsertLast(30);
            UC8.InsertLast(70);
            Console.WriteLine("Linked list before insertion:");
            UC8.Display();
            UC8.FindAndInsert(UC8.head.next, 40);
            UC8.Display();
            Console.ReadLine();

            Console.WriteLine("*****uc9******");
            UC9 UC9 = new UC9();
            UC9.InsertLast(56);
            UC9.InsertLast(30);
            UC9.InsertLast(40);
            UC9.InsertLast(70);
            Console.WriteLine("Linked list before deletion:");
            UC9.Display();
            UC9.DeleteNode(40);
            Console.WriteLine("Linked list after deletion:");
            UC9.Display();
            Console.WriteLine("The size of the list:" + UC9.Size());
            Console.ReadLine();

            
            Console.WriteLine("*****uc10******");
            UC10 UC10 = new UC10();
            UC10.InsertLast(70);
            UC10.InsertLast(30);
            UC10.InsertLast(56);
            UC10.InsertLast(40);
            UC10.Display();
            Console.WriteLine("\n Sorted list in ascending order");
            UC10.sortList();
            UC10.Display();
        }
    }
}