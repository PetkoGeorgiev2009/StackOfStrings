using StackStrings_Upr;

StackOfStrings stack = new StackOfStrings();

stack.Push("Apple");
stack.Push("Banana");
stack.Push("Orange");

Console.WriteLine(stack.Peek()); 

Console.WriteLine(stack.Pop());  
Console.WriteLine(stack.Pop());  

Console.WriteLine(stack.IsEmpty()); 

Console.WriteLine(stack.Pop());  

Console.WriteLine(stack.IsEmpty()); 