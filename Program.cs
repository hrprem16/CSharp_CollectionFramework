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
            //C# Dictionary<TKey, TValue> :-
            //C# Dictionary<TKey, TValue> class uses the concept of hashtable. It stores values on the basis of key.
            //It contains unique keys only. By the help of key, we can easily search or remove elements
            //The working of Dictionary is quite similar to the non-generic hashtable.
            //It is dynamic in nature means the size of the dictionary is grows according to the need

            //Example:-
            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("1", "Sonoo");
            names.Add("2", "Peter");
            names.Add("3", "James");
            names.Add("4", "Ratan");
            names.Add("5", "Irfan");

            foreach (KeyValuePair<string, string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }

            Console.WriteLine("Elements in dictionary names : " + names.Count);

            Console.WriteLine("{0}", names.Keys.ElementAt(0));// Find the key at index 0
            Console.WriteLine(names[names.Keys.ElementAt(0)]); // get he value at index 0\

            //names[key]--> get the value for that key
            //Clear: This method removes all keys and values from the Dictionary<TKey,TValue>.
            //Remove: This method removes the value with the specified key from the Dictionary<TKey,TValue>.
            names.Remove("2");// remove the value and key
            Console.WriteLine(names.ContainsKey("3")); //This method is used to check whether the Dictionary<TKey,TValue> contains the specified key.
            Console.WriteLine(names.ContainsValue("James")); //This method is used to check whether the Dictionary<TKey,TValue> contains a specific value.

            Console.WriteLine(names.TryGetValue("4",out string value));
            string targetValue = "Irfan";
            string key = names.FirstOrDefault(x => x.Value == targetValue).Key;
            Console.WriteLine(key);


        }
    }

}




