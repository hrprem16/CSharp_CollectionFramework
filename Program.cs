using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Microsoft.VisualBasic;

namespace Collection_Framework
{
    class Program
    {
        public static void Main(string[] args)
        {
            //C# LinkedList<T>
            //C# LinkedList<T> class uses the concept of linked list. It allows us to insert and delete elements fastly.
            //It can have duplicate elements.

            LinkedList<string> lk1 = new LinkedList<string>(); // Creatin LL of string
            lk1.AddLast("Sonoo Jaiswal");
            lk1.AddLast("Ankit");
            lk1.AddLast("Peter");
            lk1.AddLast("Irfan");
            lk1.AddFirst("John");//added to first index  

            // Iterate list element using foreach loop  
            foreach (var name in lk1)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Element present in LL are: " + lk1.Count);

            //Let's see another example of generic LinkedList<T> class that stores elements before and after specific node.
            //To get the specific node, we are calling Find() method.
            LinkedListNode<String> node = lk1.Find("Peter"); //find node which contains peter
            lk1.AddAfter(node, "Prince"); // Add Node after Peter
            lk1.AddBefore(node, "Chandru"); // Add
            Console.WriteLine("After add node at spefic position");

            foreach (var name in lk1)
            {
                Console.WriteLine(name);
            }
            lk1.Remove("Irfan");
            lk1.Remove(node);
            lk1.RemoveFirst();
            lk1.RemoveLast();
            Console.WriteLine("*****************");
            foreach (var name in lk1)
            {
                Console.WriteLine(name);
            }

            //Clear(): This method is used to remove all nodes from the LinkedList.

            Console.WriteLine("Is Chandru is present in node: " + lk1.Contains("Chandru"));

            

        }
    }

}




