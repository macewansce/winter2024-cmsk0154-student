using System;
using System.Collections.Generic;

namespace Module4.Lesson19.Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            // Queues
            //
            // Represents a variable size last-in-first-out (FIFO) 
            // collection of instances of the same specified type.

            // Queue<T> is implemented as an array.

            // Queues are useful when you need temporary storage for information; 
            // that is, when you might want to discard an element after retrieving its value.

            // Think of a queue as a line up at a bank. People in the front of the line are
            // the next person that is served. In other words, the First person in the line
            // is the next person that is served when a teller is available

            // Defining a Queue
            //

            Queue<int> numbers = new Queue<int>();

            Queue<string> names = new Queue<string>();

            Queue<Part> parts = new Queue<Part>();


            // Adding items onto a Queue
            //

            // Adding items onto a Queue is done using the 'Engueue' method.
            //
            // Below are some examples of "queueing an item onto the queue"

            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);

            foreach (var item in numbers)
                Console.WriteLine(item);

            // output
            //
            // 1
            // 2
            // 3

            // The order in which is display is the opposite to a stack... The, first item 
            // placed into the Queue is the first item out, the the second, then the third
            // etc


            //////////////////////////////////////////////////////////////////////
            //
            // Adding reference types, like string and Part to a queue
            //

            Queue<Part> partQueue = CreatePartsQueue();

            foreach (var part in partQueue)
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
            // Removing items from a queue
            //

            // - Removing an item from a queue is done using the 'Dequeue' method
            // - When you 'Dequeue' an item from the queue - the items is removed from the
            //   queue and returned

            // using our numbers queue (which contains 3 numbers), when we call 'Dequeue',
            // the number '1' is returned. Why, because 1 is the first number Enqueued
            // into the queue and therefore the first item returned.... remember FIFO
            //
            // let's try this...

            int poppedNumber3 = numbers.Dequeue();
            Console.WriteLine(poppedNumber3);

            // output ... 3

            // Now, lets look at our numbers queue
            foreach (var item in numbers)
                Console.WriteLine(item);

            // output
            //
            // 2
            // 1

            // NOTE: your program will throw an exception error if you try and 'pop'
            // something from the queue when there are no items on the queue
            //
            // continuing with our numbers queue...

            int poppedNumber2 = numbers.Dequeue();
            Console.WriteLine(poppedNumber2);    // should output 2

            int poppedNumber1 = numbers.Dequeue();
            Console.WriteLine(poppedNumber1);    // should output 1

            // numbers queue now has no items on the queue
            Console.WriteLine(numbers.Count);    // should output 0

            try
            {
                numbers.Dequeue();  // this will cause an exception eerror
            }
            catch
            {
                Console.WriteLine("Pop was called on an empty queue!");
            }

            // The best way to handle this is by using an if statement checking
            // that the queue has items to 'pop' before calling the pop method

            // NOTE: the following is only allowed in C# 9 or higher
            // in the project config, add <LangVersion>latest</LangVersion>

            int? numValue = numbers.Count > 0 ? numbers.Dequeue() : null;

            // or, you can use the TryDequeue method - as follows

            int queueValue = -1;
            bool valueExists = numbers.TryDequeue(out queueValue);

            // valueExists is set to 'true' if there is an object at the top of the Queue
            // or, 'false' if the Queue is empty/
            // the queueValue will be set to the item default; for int, that value is 0
            //
            // but, what if the queue has an actual value of 0 on it???
            //     ... logical error

            // Another method that can be useful is Peek
            // Peek allows you to see what the next number is on the queue but DOES NOT
            // remove the item - like pop does.

            numbers.Enqueue(100);
            Console.WriteLine(numbers.Count);    // output 1

            int peekNumber = numbers.Peek();
            Console.WriteLine(numbers.Count);    // output 1

            int popNumber = numbers.Dequeue();
            Console.WriteLine(numbers.Count);    // output 0

            // NOTE:
            //
            // Peek, like Dequeue, will return an exception if there are no items on the queue
            // Like Dequeue, you can use an if statement or TryPeek() to get around the error

            // Lastly, the Queue has a Contains method which allows you to search the queue
            // for an item... 

            // First, add some items onto the queue
            //
            numbers.Enqueue(10);
            numbers.Enqueue(20);
            numbers.Enqueue(30);

            if (numbers.Contains(2))
                Console.WriteLine("The item '2' is in the Queue!");
            else
                Console.WriteLine("The item '2' is NOT in the Queue!");

            if (numbers.Contains(20))
                Console.WriteLine("The item '20' is in the Queue!");
            else
                Console.WriteLine("The item '20' is NOT in the Queue!");

            // another example
            //

            parts = CreatePartsQueue();
            Part searchPart = new Part() { PartName = "banana seat", PartId = 1444 };
            if (parts.Contains(searchPart))
                Console.WriteLine($"The part {searchPart.PartName} is in the Queue!");
            else
                Console.WriteLine($"The part {searchPart.PartName} is NOT in the Queue!");

            // why is the above code failing????

            // searchPart has the same part (based on the name and partId) in the list but
            // it fails to find this because it is using the address of the reference
            // when it checks... this is proof of this.

            // loop through the queue looking for the partId and when it finds this, 
            // assign searchPart
            foreach (Part part in parts)
            {
                Console.WriteLine($"Checking part : {part.PartId}: {part.PartName}");
                if (part.PartId == 1444)
                {
                    searchPart = part;
                    break;
                }
            }

            // now check parts.Contains...
            if (parts.Contains(searchPart))
                Console.WriteLine($"The part {searchPart.PartName} is in the Queue!");
            else
                Console.WriteLine($"The part {searchPart.PartName} is NOT in the Queue!");

            // yet, another example using strings
            //
            // for strings, even though they are reference types, this works without getting
            // a variable pointing to the same address reference in order for the Contains
            // to find it, like Parts Queue
            //

            Console.WriteLine("Example of Contains using strings...");
            names.Enqueue("Allan");
            names.Enqueue("Bob");
            names.Enqueue("Karen");
            names.Enqueue("Jill");
            names.Enqueue("Peter");

            if (names.Contains("Bob"))
                Console.WriteLine($"Bob is in the names Queue!");
            else
                Console.WriteLine($"Bob is NOT in the names Queue!");

        }


        static Queue<Part> CreatePartsQueue()
        {
            Queue<Part> parts = new Queue<Part>();
            parts.Enqueue(new Part() { PartName = "crank arm", PartId = 1234 });
            parts.Enqueue(new Part() { PartName = "chain ring", PartId = 1334 });
            parts.Enqueue(new Part() { PartName = "regular seat", PartId = 1434 });
            parts.Enqueue(new Part() { PartName = "banana seat", PartId = 1444 });
            parts.Enqueue(new Part() { PartName = "cassette", PartId = 1534 });
            parts.Enqueue(new Part() { PartName = "shift lever", PartId = 1634 });

            return parts;
        }
    }
}
