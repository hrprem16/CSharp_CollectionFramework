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
            //C# SortedSet<T>
            //C# SortedSet class can be used to store, remove or view elements. It maintains ascending order and does not
            //store duplicate elements. It is suggested to use SortedSet class if you have to store unique elements and maintain ascending order.
            //It is found in System.Collections.Generic namespace.

            SortedSet<string> ss = new SortedSet<string>(); // Creating Sorted set of type string

            ss.Add("Ankit"); // add or store element in ss SortedSet
            ss.Add("Chandra");
            ss.Add("Dhanush");
            ss.Add("Elye");
            ss.Add("Gokul");
            ss.Add("Ankit"); // duplicate will not be added

            // Rest the remaning method and properties are same as HashSet


        }
    }

}




