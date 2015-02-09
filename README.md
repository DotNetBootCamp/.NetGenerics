# .NetGenerics
Intro to generics in C#

# The problem #

So, you want to store a list of strings and you don't want to use an array data type because you are going to be adding and removing items frequently from different parts of the data structure. What do you do?
You might end up writing something like the following class:

> See StringList.cs

Okay great, but what if you want to store integers instead of strings? Well you could make a copy of the StringList.cs file and create an intList.cs ... But pretty soon you are going to get tired of copy pasting code every time you need a new type of list. This should also set off alarm bells every time you do it since it is a code smell. As we know bugs come from code, the more you copy paste, the more code you have, the more bugs you have.

You might even get so fed up you try solve the problem by creating a objectList class, since in .net everything eventually inherits from the object class. The problem is how do you know what type the object was when you get it out of the list? You could write a switch statement to check the typeof for the output but switches are another code smell. You could write a list that stored an object like this:

    Public class ListObject
	{
		Type ObjectType { get; set; }
		Object TheObjectToStore { get; set; }
	}

But this is cumbersome and would quickly get frustrating.

## Enter Generics ##

> See GenericList.cs

We can then user our generic class as follows:

	var stringList = new GenericList<string>();
	stringList.Add("potato");
	...

Much easier!

From MSDN (https://msdn.microsoft.com/en-us/library/512aeb7t.aspx) :

> ## Generics Overview ##
> - Use generic types to maximize code reuse, type safety, and performance.
> - The most common use of generics is to create collection classes.
> - The .NET Framework class library contains several new generic collection classes in the System.Collections.Generic namespace. These should be used whenever possible instead of classes such as ArrayList in the System.Collections namespace.
> - You can create your own generic interfaces, classes, methods, events and delegates.
> - Generic classes may be constrained to enable access to methods on particular data types.
> - Information on the types that are used in a generic data type may be obtained at run-time by using reflection.

primities such as int can be made nullable through the use of generics, to mark an int as nullable simply do the following:

	public int? AwesomeValue { get; set; }

This is an alias for:

	publick Nullable<int> Awesome Value { get; set; }

## Excercise ##
1. You are writing a library that manages user search requests for media items(Movies, TV Series, Music, Books, etc) and stores them in memory in a queue. 
2. The library has three types of items it must cater for:
	- Items that implement the IMediaItemQuery interface
	- Items that are strings only
	- Items that are any other .net class that can be newed up with a default constructor
3. Each queue you implement must have a public push and pop method
4. It's up to you if you implement one queue or 3
5. Your application must implement the IMediaQueueService interface 