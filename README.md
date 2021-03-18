# StackClass
Class Stack and programm that use it.
-----------------------------------
A Stack is a data structure for storing a list of elements in a LIFO 
(last in, first out) fashion. Designed a class called Stack with three methods. 

void Push(object obj)

object Pop()

void Clear()


The Push() method stores the given object on top of the stack. We use the “object” type here so we can store any objects inside the stack. The “object” class is the base of all classes in the .NET. So any types can be automatically upcast to the object. This scenario assumes that null is passed to this object. The null shouldn't be stored in the stack. So if null is passed to this method, we throw an InvalidOperationException. 

The Pop() method removes the object on top of  the stack and returns it. Into account the scenario assumes that we call the Pop() method on an empty stack. In this case, this method throw an InvalidOperationException. 

The Clear() method removes all objects from the stack.
 
This stack class able to be used as follows:

var stack = new Stack();

stack.Push(1);

stack.Push(2);

stack.Push(3);


Console.WriteLine(stack.Pop());

Console.WriteLine(stack.Pop());

Console.WriteLine(stack.Pop());


The output of this program will be
3

2

1



