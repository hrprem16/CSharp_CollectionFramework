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
            // C# HashSet class can be used to store, remove or view elements. It does not store duplicate elements.
            // It is suggested to use HashSet class if you have to store only unique elements.
            //It is generic collection 
            HashSet<string> names = new HashSet<string>();

            // Add() -> used to add or store elements or objects in Hashset
            names.Add("Aman");
            names.Add("Ashish");
            names.Add("Atharva");
            names.Add("Prince");
            // Iterate HashSet elements using foreach loop

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            //Let's see another example of generic HashSet<T> class that stores elements using Collection initializer.

            var hs = new HashSet<string>() { "Sonoo", "Ankit", "Peter", "Irfan" };

            // Iterate HashSet elements using foreach loop  
            foreach (var name in hs)
            {
                Console.WriteLine(name);
            }
            //Count: Gets the number of elements contained in the HashSet<T>
            Console.WriteLine("No of object in hs hashset: " + hs.Count);

            //Remove(T item): Removes the specified element from the HashSet< T>

            hs.Remove("Peter");

            //Contains(T item): Determines whether the HashSet<T> contains a specific value
            bool containsele = hs.Contains("Prince");
            Console.WriteLine("hs Hashset contains Prince : "+containsele);



            //Clear(): Removes all elements from the HashSet<T>.
            hs.Clear();

            //HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };

            //HashSet<int> set2 = new HashSet<int> { 5,6, 3,7, 8, 7, 9 };

            ////UnionWith(IEnumerable < T > other): Modifies the current set to contain all elements present in itself,
            ////in the specified collection, or in both.
            ////set1.UnionWith(set2);
            //foreach(var i in set1)
            //{
            //    Console.Write(i+" "); //print the union of set1 and set2
            //}
            //Console.WriteLine();
            ////IntersectWith(IEnumerable<T> other): Modifies the current set to contain only elements that
            ////are present in both the set and the specified collection.
            ////// Modifies set1 to contain only elements present in both set1 and set2
            //set1.IntersectWith(set2);
            //Console.WriteLine("Modified set1:");
            //foreach (var item in set1)
            //{
            //    Console.Write(item+" ");
            //}

            //IsSubsetOf(IEnumerable<T> other): Determines whether the HashSet<T> is a subset of a specified collection.
            HashSet<int> set1 = new HashSet<int> { 1, 2 };
            HashSet<int> set2 = new HashSet<int> { 1, 2, 3, 4, 5 };
            bool isSubset = set1.IsSubsetOf(set2);
            Console.WriteLine("set1 is subset of set2 : " + isSubset);

            //IsSupersetOf(IEnumerable<T> other): Determines whether the HashSet<T> is a superset of a specified collection.
            Console.WriteLine("set2 is superset of set1 : " + set2.IsSupersetOf(set1));


        }
    }

}




