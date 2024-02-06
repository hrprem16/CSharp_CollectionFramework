using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace Collection_Framework
{
    class Program
    {
        public static void Main(string[] args)
        {
            //C# SortedDictionary<TKey, TValue>
            // C# SortedDictionary<TKey, TValue> class uses the concept of hashtable. It stores values on the basis of key.
            // It contains unique keys and maintains ascending order on the basis of key. By the help of key, we can easily search or remove elements.

            SortedDictionary<string, string> names = new SortedDictionary<string, string>();
            names.Add("1", "Sonoo");
            names.Add("4", "Peter");
            names.Add("5", "James");
            names.Add("3", "Ratan");
            names.Add("2", "Irfan");
            foreach (KeyValuePair<string, string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }

            // Rest the properties is same for SortedDictionary 
        }
    }

}




