using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;
namespace Collection_Framework
{
    class Program
    {
        public static void Main(string[] args)
        {
            //A stack represents LIFO (last in first out ) order.
            // Creating Non-generic Stack that store multiple type of values
            Stack stk1 = new Stack();
            // add element or store elements in stack using Push()
            stk1.Push(1);
            stk1.Push("Pranit");
            stk1.Push(3);
            stk1.Push('A');
            stk1.Push("Satish");
            stk1.Push(4);

            foreach (var i in stk1)
            {
                Console.Write(i + " ");
            }

            // Count ->> This method is used to count the element
            Console.WriteLine();

            Console.WriteLine("Number of element in the stack stk1 is :" + stk1.Count);

            //Pop() ->>This method removes the beginning element of the stack

            stk1.Pop(); // it delete the top element of stack

            //Peek() ->>This method returns the object at the beginning of the stack without removing it.

            stk1.Peek();

            //Count ->> This method used to count the elements that present in the stack
            int a = stk1.Count;
            Console.WriteLine(a);

            //Contains() // Determines the elements present in the stack
            Console.WriteLine("Satish is Present in stack st1 : " + stk1.Contains("Satish")); 

            //Clear() ->> This method is used to clear entire elements from the stack
            stk1.Clear();



            //Creating Generic stack that store specific type of elements
            Stack<int> stk2 = new Stack<int>();
            // add element or store elements in stack using Push()
            stk2.Push(1);
            stk2.Push(2);
            stk2.Push(3);
            stk2.Push(4);
            stk2.Push(5);
            stk2.Push(6);

            foreach (int i in stk2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            

        }
    }

}




