# .NetGenerics
Intro to generics in C#

# The problem #

So, you want to store a list of strings and you don't want to use an array data type because you are going to be adding and removing items frequently from different parts of the data structure. What do you do?
You might end up writing something like the following class:

> See StringList.cs

Okay great, but what if you want to store integers instead of strings? Well you could make a copy of the StringList.cs file and create an intList.cs

> See intList.cs

 You could even take it a step further and create a common class to share some of the functionality between them. The problem is every time you want to store a list of some new type, you are going to have to create a new list class. Seems like big waste of time.

Perhaps you might try get around the problem by creating a objectList class, since in .net everything eventually inherits from the object class.

> see objectList.cs