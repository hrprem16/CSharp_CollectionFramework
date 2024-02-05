# LocoBuzz_Collection_Framework
Collection in C# represent a group of objects. By help of collection we perform various operations on objects like:
->Store
->Update
->Delete
->Retrive
->Search

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








#HashSet
C# HashSet class can be used to store, remove or view elements. It does not store duplicate elements. It is suggested to use HashSet class if you have to store only unique elements.
+ .HashSet<Type_of_hashset> Hashset_name = new HashSet<Type_of_hashset>();
Inbuilt function are:
+ .Add(item)
+ .Remove(item)
+ .RemoveAt(index)
+ .Clear() // clear the entire hashset
+ .IndexOf(<value>)

#SortedSet
C# SortedSet class can be used to store, remove or view elements. It maintains ascending order and does not store duplicate elements.
Inbuilt function are:
+ .Add(item)
+ .Remove(item)
+ .RemoveAt(index)
+ .Clear() // clear the entire hashset
+ .IndexOf(<value>)

