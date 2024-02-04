using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace Collection_Framework
{
    class Program
    {
        public static void Main(string[] args)
        {
           //Creating a list of string
            List<string> myList = new List<string>();

            // Create a list of integer using collection initializer
            List<int> myList1=new List<int> { 1,2,3,4,5,6 };

            foreach(int i in myList1)
            {
                Console.Write(i+" ");
            }

            // Add or store elements in myList
            myList.Add("Sonoo Jaiswal");
            myList.Add("Ankit");
            myList.Add("Peter");
            myList.Add("Irfan");

            foreach (var i in myList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("No of element in myList1 is : " + myList1.Count);

            myList.Remove("Ankit"); // Remove the first occurence of a specific element from the list
            myList.RemoveAt(2); // Remove the 2nd index element

            myList1.RemoveAll(x => x % 2 == 0);// remove all the elements that match the condtion

            myList.RemoveRange(0, 2); // remove all the even number from the list myList
            myList.Clear(); // remove all the element from the list

            myList1.Contains(4); // Determines whether the list contains a specific value

            myList1.IndexOf(2); // return the index of the element

            Console.WriteLine(myList1.Count); // reutrn the number of elements contained in the list
            Console.WriteLine(myList1.Capacity); // determines the currenlty capacity of the list
            myList1[3] = 10; // update the 3rd index of myList1 list

            myList1.Sort(); // sort the list in ascending order;







        }
    }

}




