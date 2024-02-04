using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace Collection_Framework
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Ctreating a collection of ints
            Collection<int> MyColls = new Collection<int>();

            //Adding elements in the collection MyColls
            MyColls.Add(1);
            MyColls.Add(2);
            MyColls.Add(3);
            MyColls.Add(4);
            MyColls.Add(5);

            //Dispplay the elements in MyColls
            foreach(int i in MyColls)
            {
                Console.Write(i+" ");
            }

            //Gets the number of elements actually contained in MyColls
            Console.WriteLine("\nNo of elements contained in MyColls: " + MyColls.Count);

            // Get the element at index 2 
            Console.WriteLine("Element at index 2 is : " + MyColls[2]);

            // Checking if an element is in the Collection 
            // The function returns "True" if the 
            // item is present in Collection 
            // else returns "False" 
            Console.WriteLine(MyColls.Contains(2));
            Console.WriteLine("\nIndex 3 is : " + MyColls.IndexOf(3));
            //Removes the first occurrence of a specific object from the Collection
            MyColls.Remove(3);
            //Removes the element at the specified index of the Collection
            MyColls.RemoveAt(1);
            //Removes all elements from the Collection
            MyColls.Clear();
            Console.WriteLine("\nNo of elements contained in MyColls after Clear() : " + MyColls.Count);




            //Ctreating a collection of string
            Collection<string> MyColls1 = new Collection<string>();

            // Add the elements in MyColls1
            MyColls1.Add("Amit");
            MyColls1.Add("Raj");
            MyColls1.Add("Sanu");
            MyColls1.Add("Rahul");
            MyColls1.Add("Sid");
            MyColls1.Add("Ankit");


            // Creating a string array 
            string[] myArr = new string[MyColls1.Count];

            // Copying the entire Collection to a 
            // compatible one-dimensional Array, 
            // starting at the specified index 
            // of the target array 
            MyColls1.CopyTo(myArr, 0);

            //Display the elements in the array myarr
            foreach(string str in myArr)
            {
                Console.Write(str +" ");
            }
            Console.WriteLine("\nIndex of Rahul in MyColls1 : "+ MyColls1.IndexOf("Rahul"));





        }
    }

}




