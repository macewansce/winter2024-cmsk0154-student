using System;
using System.Collections.Generic;

namespace Module4.Lesson18.Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stacks
            //
            // Represents a variable size last-in-first-out (LIFO) 
            // collection of instances of the same specified type.

            // Stack<T> is implemented as an array.

            // Stacks are useful when you need temporary storage for information; 
            // that is, when you might want to discard an element after retrieving its value.

            // Think of a stack as a 'stack' of plates, when you add a plate onto the
            // stack of plates it goes on top of them. Then, when you need to get a plate,
            // the plate on top of the stack is the plate you receive... Last on top of
            // the stack of plates is the first one that comes off when you get a plate.
            //

            // Defining a Stack
            //

            Stack<int> numbers = new Stack<int>();

            Stack<string> names = new Stack<string>();

            Stack<Part> parts = new Stack<Part>();


            // Adding items onto a Stack
            //

            // Adding items onto a Stack is done using the 'Push' method.
            //
            // Below are some examples of "pushing an item onto the stack"

            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);

            foreach (var item in numbers)
                Console.WriteLine(item);

            // output
            //
            // 3
            // 2
            // 1

            // when we iterate through the list, it seems as if it's backwards.
            // it's not; 1 was the first item pushed, then 2, then 3. Therefore,
            // the last item pushed was 3 and is therefore at the top of the list
            //


            //////////////////////////////////////////////////////////////////////
            //
            // Adding reference types, like string and Part to a stack
            //

            Stack<Part> partStack = CreatePartsStack();

            foreach (var part in partStack)
                Console.WriteLine(part.PartName);

            // output
            //
            //   shift lever
            //   cassette
            //   banana seat
            //   regular seat
            //   chain ring
            //   crank arm


            //////////////////////////////////////////////////////////////////////
            //
            // Removing items from a stack
            //

            // - Removing an item from a stack is done using the 'Pop' method
            // - When you 'pop' an item from the stack - the items is removed from the
            //   stack and returned

            // using our numbers stack (which contains 3 numbers), when we call 'pop',
            // the number '3' is returned. Why, because 3 was the last number pushed
            // onto the stack and therefore the first item returned.... remember LIFO
            //
            // let's try this...

            int poppedNumber3 = numbers.Pop();
            Console.WriteLine(poppedNumber3);

            // output ... 3

            // Now, lets look at our numbers stack
            foreach (var item in numbers)
                Console.WriteLine(item);

            // output
            //
            // 2
            // 1

            // NOTE: your program will throw an exception error if you try and 'pop'
            // something from the stack when there are no items on the stack
            //
            // continuing with our numbers stack...

            int poppedNumber2 = numbers.Pop();
            Console.WriteLine(poppedNumber2);    // should output 2

            int poppedNumber1 = numbers.Pop();
            Console.WriteLine(poppedNumber1);    // should output 1

            // numbers stack now has no items on the stack
            Console.WriteLine(numbers.Count);    // should output 0

            try
            {
                numbers.Pop();  // this will cause an exception eerror
            }
            catch
            {
                Console.WriteLine("Pop was called on an empty stack!");
            }

            // The best way to handle this is by using an if statement checking
            // that the stack has items to 'pop' before calling the pop method

            // NOTE: the following is only allowed in C# 9 or higher
            // in the project config, add <LangVersion>latest</LangVersion>

            int? numValue = numbers.Count > 0 ? numbers.Pop() : null;

            // or, you can use the TryPop method - as follows

            int stackValue = -1;
            bool valueExists = numbers.TryPop(out stackValue);

            // valueExists is set to 'true' if there is an object at the top of the Stack
            // or, 'false' if the Stack is empty/
            // the stackValue will be set to the item default; for int, that value is 0
            //
            // but, what if the stack has an actual value of 0 on it???
            //     ... logical error

            // Another method that can be useful is Peek
            // Peek allows you to see what the next number is on the stack but DOES NOT
            // remove the item - like pop does.

            numbers.Push(100);
            Console.WriteLine( numbers.Count);    // output 1

            int peekNumber = numbers.Peek();
            Console.WriteLine(numbers.Count);    // output 1

            int popNumber = numbers.Pop();
            Console.WriteLine(numbers.Count);    // output 0

            // NOTE:
            //
            // Peek, like Pop, will return an exception if there are no items on the stack
            // Like Pop, you can use an if statement or TryPeek() to get around the error

            // Lastly, the Stack has a Contains method which allows you to search the stack
            // for an item... 

            // First, add some items onto the stack
            //
            numbers.Push(10);
            numbers.Push(20);
            numbers.Push(30);

            if (numbers.Contains(2))
                Console.WriteLine("The item '2' is in the Stack!");
            else
                Console.WriteLine("The item '2' is NOT in the Stack!");

            if (numbers.Contains(20))
                Console.WriteLine("The item '20' is in the Stack!");
            else
                Console.WriteLine("The item '20' is NOT in the Stack!");

            // another example
            //

            parts = CreatePartsStack();
            Part searchPart = new Part() { PartName = "banana seat", PartId = 1444 };
            if (parts.Contains(searchPart))
                Console.WriteLine($"The part {searchPart.PartName} is in the Stack!");
            else
                Console.WriteLine($"The part {searchPart.PartName} is NOT in the Stack!");

            // why is the above code failing????

            // searchPart has the same part (based on the name and partId) in the list but
            // it fails to find this because it is using the address of the reference
            // when it checks... this is proof of this.

            // loop through the stack looking for the partId and when it finds this, 
            // assign searchPart
            foreach(Part part in parts)
            {
                Console.WriteLine($"Checking part : {part.PartId}: {part.PartName}");
                if (part.PartId==1444)
                {
                    searchPart = part;
                    break;
                }
            }

            // now check parts.Contains...
            if (parts.Contains(searchPart))
                Console.WriteLine($"The part {searchPart.PartName} is in the Stack!");
            else
                Console.WriteLine($"The part {searchPart.PartName} is NOT in the Stack!");

            // yet, another example using strings
            //
            // for strings, even though they are reference types, this works without getting
            // a variable pointing to the same address reference in order for the Contains
            // to find it, like Parts Stack
            //

            Console.WriteLine("Example of Contains using strings...");
            names.Push("Allan");
            names.Push("Bob");
            names.Push("Karen");
            names.Push("Jill");
            names.Push("Peter");

            if (names.Contains("Bob"))
                Console.WriteLine($"Bob is in the names Stack!");
            else
                Console.WriteLine($"Bob is NOT in the names Stack!");

        }


        static Stack<Part> CreatePartsStack()
        {
            Stack<Part> parts = new Stack<Part>();
            parts.Push(new Part() { PartName = "crank arm", PartId = 1234 });
            parts.Push(new Part() { PartName = "chain ring", PartId = 1334 });
            parts.Push(new Part() { PartName = "regular seat", PartId = 1434 });
            parts.Push(new Part() { PartName = "banana seat", PartId = 1444 });
            parts.Push(new Part() { PartName = "cassette", PartId = 1534 });
            parts.Push(new Part() { PartName = "shift lever", PartId = 1634 });

            return parts;
        }

    }
}
