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

