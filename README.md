# LocoBuzz_Collection_Framework
Collection in C# represent a group of objects. By help of collection we perform various operations on objects like:
+ Store
+ Update
+ Delete
+ Retrive
+ Search

# Types of Collections:
There are three different ways to work with Collections.
--System.Collections.Generic classes
  + List
  + Stack
  + Queue
  + Linked List
  + Hash Set
  + Sorted Set
  + Dictionary
  + Sorted Dictionary
  + Sorted List
--System.Collections classes (Now deprecated)
  + ArrayList
  + Stack
  + Queue
  + Hash Table
--System.Collections.Concurrent classes

# List 
List<T> class is used to store and fetch elements. It can have duplicate elements.
Inbuilt function are:
+ .Add(3)
+ .Remove()
+ .AddRange()
+ .RemoveAt(0) //to remove at particular location
+ .IndexOf(<value>)

# Queue
Queue<T> class is used to Enqueue and Dequeue elements. It uses the concept of Queue that arranges elements in FIFO (First In First Out) order. It can have duplicate elements.
Inbuilt function are:
+ .Enqueue(1);
+ .Dequeue();
+ .Peek();
+ .Count();
+ .Clear();
+ .Contains(2);
+ .ToArray();

# Stack
Stack<T> class is used to push and pop elements. It uses the concept of Stack that arranges elements in LIFO (Last In First Out) order. It can have duplicate elements.
Inbuilt function are:
+ .Push(1);
+ .Pop();
+ .Peek();
+ .Count;
+ .Clear();
+ .Contains(2);
+ .ToArray();

# HashSet
C# HashSet class can be used to store, remove or view elements. It does not store duplicate elements. It is suggested to use HashSet class if you have to store only unique elements.
+ .HashSet<Type_of_hashset> Hashset_name = new HashSet<Type_of_hashset>();
Inbuilt function are:
+ .Add(item)
+ .Remove(item)
+ .RemoveAt(index)
+ .Clear() // clear the entire hashset
+ .IndexOf(<value>)

# SortedSet
C# SortedSet class can be used to store, remove or view elements. It maintains ascending order and does not store duplicate elements.
Inbuilt function are:
+ .Add(item)
+ .Remove(item)
+ .RemoveAt(index)
+ .Clear() // clear the entire hashset
+ .IndexOf(<value>)

# LinkedList
C# LinkedList<T> class uses the concept of linked list. It allows us to insert and delete elements fastly. It can have duplicate elements.
+ .AddLast() 
+ .AddFirst()
+ .LinkedListNode<String> node=names.Find("Peter")//
+ .AddBefore(node, "John");
+ .AddAfter(node, "Lucy");  

# Dictionary<TKey, TValue>
C# Dictionary<TKey, TValue> class uses the concept of hashtable. It stores values on the basis of key. It contains unique keys only. By the help of key, we can easily search or remove elements.
+ .Add(<key>,<value>)
+ .Count // get the key-value pairs contains in dictionary
+ .dictionary_name.TryGetValue("value", out in value)
+ .<datatyppe of key> key = myDictionary.FirstOrDefault(x => x.Value == 2).Key; // Finding the key for a specific value (e.g., value = 2)
