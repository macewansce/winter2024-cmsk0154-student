using System;
using System.Collections.Generic;
using System.Linq;

namespace Module4.Lesson17.Lists
{

    class Program
    {
        static void Main(string[] args)
        {
            //ListFundamentals();
            //AddingItemsInAList();
            //RemovingItemsInAList();
            //SearchingItemsInAList();
            //WorkingWithAStringList();
            //ComplexItemsInAList();

            List<Part> parts = AddingObjectsToList();
            FindingAllObjectsWithinList(parts);
        }

        static void ListFundamentals()
        {

            // The List<T> class allows us to maintain a list of something ('T') 
            // It implements the IList<T> generic interface by using an array whose 
            // size is dynamically increased as required.

            // 'T' represents a Type... any Type - value and reference types
            //

            // For example:
            //
            //      List<int> defines a list of integers
            //      List<string> defines a list of strings
            //      List<Animal> defines a list of Animals
            //


            // creating a list of numbers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }

        static void AddingItemsInAList()
        {
            ////////////////////////////////////////////////////////////////////////
            //
            // adding items in the list
            // 

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // adding a new item at the end of the list
            //
            numbers.Add(20);

            // adding another list
            List<int> moreNumbers = new List<int>() { 31, 32, 33, 34, 35 };
            numbers.AddRange(moreNumbers);

            // inserting an item in the list
            //
            //     The code below does the following:
            //
            //                    50
            //                    |
            //     1, 2, 3, 4, 5, 6, 7, 8, 9, 10 
            //
            // end result...
            //
            //     1, 2, 3, 4, 5, 50, 6, 7, 8, 9, 10 

            int newNumber = 50;
            numbers.Insert(5, newNumber);


            // inset a new list of items into our existing list
            List<int> insertedNumbers = new List<int>() { 20, 30, 40 };
            numbers.InsertRange(5, insertedNumbers);

            // output the list after the above add related methofs
            //
            foreach (var num in numbers)
                Console.Write(num + ", ");
            Console.WriteLine();


        }

        static void RemovingItemsInAList()
        {

            ////////////////////////////////////////////////////////////////////////
            //
            // removing items in the list
            // 

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // remove an item from the list
            bool removed9 = numbers.Remove(9);
            Console.WriteLine(removed9 ? "9 was removed from the list"
                                        : "9 was not removed from the list");


            // remove a range item from the list
            numbers.RemoveRange(2, 3);

            // RemoveRange(2, 3) would do the following
            //
            // before { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // after  { 1, 2, 6, 7, 8, 9, 10 };

            // remove an item at index number 6 (the 7th number in the list)
            numbers.RemoveAt(6);

            // RemoveAt(6) would do the following
            //
            // before { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // after  { 1, 2, 3, 4, 5, 6, 8, 9, 10 };

            // output the list after the above add related methofs
            //
            foreach (var num in numbers)
                Console.Write(num + ", ");
            Console.WriteLine();
        }

        static void SearchingItemsInAList()
        {

            ////////////////////////////////////////////////////////////////////////
            //
            // getting/searching items from the list
            // 
            // because our list is a List<int>, the items are intergers 
            //

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // access an item in the list using an index
            //
            int n = numbers[4];
            Console.WriteLine($"using 'numbers[4]' returns {n}"); // indexes start at 0

            // find an item in the list using the find method
            //
            int n2 = numbers.Find(x => x == 3);
            Console.WriteLine($"using 'numbers.Find( x=> x==3)' returns {n2}");

            // get the total number of items in the list using Count
            //
            int totalNumbers = numbers.Count;
            Console.WriteLine($"total number of items in the list is {totalNumbers}");

            // using Contains, check to see if something is in the list
            //
            bool exists = numbers.Contains(8);
            Console.WriteLine($"check to see if the number 8 is in the list: {exists}");

        }

        static void WorkingWithAStringList()
        {
            // Working with a List<string> is no different from List<int>
            // - adding/removing is the same
            // - below, we will just look at some of the getting/search methods
            //

            ////////////////////////////////////////////////////////////////////////
            //
            // getting/searching items from the list
            // 
            // because our list is a List<string>, the items are strings 
            //

            List<string> names = new List<string> { 
                "Allan", "Kevin", "Karen", "Matthew", "Samantha", "Joanne", "Peter"
            };

            // output the list after the above add related methofs
            //
            foreach (var name in names)
                Console.Write(name + ", ");
            Console.WriteLine();


            // access an item in the list using an index
            //
            string s = names[4];
            Console.WriteLine($"using 'names[4]' returns {s}");

            // find an item in the list using the find method
            //
            string s2 = names.Find(x => x == "James");
            Console.WriteLine($"using 'names.Find(x => x == \"James\")' returns \"{s2}\"");

            string s3 = names.Find(x => x == "Karen");
            Console.WriteLine($"using 'names.Find(x => x == \"Karen\")' returns \"{s3}\"");


            // get the total number of items in the list using Count
            //
            int totalNumbers = names.Count;
            Console.WriteLine($"total number of items in the list is {totalNumbers}");

            // using Contains, check to see if something is in the list
            //
            bool exists = names.Contains("Allan");
            Console.WriteLine($"check to see if \"Allan\" is in the list: {exists}");

        }

        static void ComplexItemsInAList()
        {
            // Using the Part class (defined in Part.cs)

            List<Part> parts = AddingObjectsToList();

            //RemovingObjectsFromList(parts);
            FindingObjectsWithinList(parts);

        }

        static List<Part> AddingObjectsToList()
        {
            // Create a list of parts.
            List<Part> parts = new List<Part>();

            // Add parts to the list.
            //
            parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
            parts.Add(new Part() { PartName = "chain ring", PartId = 1334 });
            parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
            parts.Add(new Part() { PartName = "banana seat", PartId = 1444 });
            parts.Add(new Part() { PartName = "cassette", PartId = 1534 });
            parts.Add(new Part() { PartName = "shift lever", PartId = 1634 });


            // adding another Parts list using AddRange
            //
            parts.AddRange(
                new List<Part>()
                {
                    new Part() { PartName = "dashboard camera", PartId = 1494 },
                    new Part() { PartName = "sunroof", PartId = 1924 },
                    new Part() { PartName = "winter tire", PartId = 1794 }
                }
            );

            // Write out the parts in the list. This will call the overridden ToString 
            // method in the Part class.
            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            // NOTE: we are returning this list to the consumer
            //

            return parts;
        }

        static void RemovingObjectsFromList(List<Part> parts)
        {
            // NOTE: we are revieving the List<Part> as a parameter
            //

            // get the first part item in the list and remove it
            //
            Part partItem = parts[0]; // crank arm
            parts.Remove(partItem);

            // remove the item at index 2 (remember, using index values start at 0)
            //
            parts.RemoveAt(2);  // banana seat

            // remove a range of items starting at index 1, remove two items
            //
            parts.RemoveRange(1, 2); // regular seat and cassette

            // Write out the parts in the list. This will call the overridden ToString 
            // method in the Part class.
            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            // after the items have been deleted... we should be left with
            //
            //    Id: 1334  Name: chain ring
            //    Id: 1634  Name: shift lever
            //    Id: 1494  Name: dashboard camera
            //    Id: 1924  Name: sunroof
            //    Id: 1794  Name: winter tire
        }
        private static void FindingObjectsWithinList(List<Part> parts)
        {
            // Returning an object/item
            //
            // Find uses a Lamda expression to look for something in the list
            // - returns the first item in the result set
            // - the result set is based on the lambda expression
            // - it returns null if not found
            //
            Part bananaSeat = parts.Find(part => part.PartId == 1444);
            Console.WriteLine(bananaSeat!=null ? "Found banana seat"
                                               : "Banana seat was not found");

            Part dualSeat = parts.Find(part => part.PartName.Contains("Dual Seat"));
            Console.WriteLine(dualSeat != null ? "Found Dual Seat"
                                               : "Dual Seat was not found");

            // Returning an index to an object/item 
            //
            // FindIndex uses a Lamda expression to look for something in the list
            // - returns an integer ( >= 0 ) in the result set
            // - the result set is based on the lambda expression
            // - it returns -1 if not found
            //
            int i = parts.FindIndex(part => part.PartId == 1444);
            Console.WriteLine(i >= 0 ? $"Found part 1444 at index {i} is {parts[i]}"
                                     : "part was not found");

            int i2 = parts.FindIndex(part => part.PartId == 9999);
            Console.WriteLine(i >= 0 ? $"Found part 1444 at index {i2} is {parts[i2]}"
                                     : "part was not found");


            // When we use FindLast, we get the last of the three items that match the
            // lamda expression: dashboard camera

            Part partItem2 = parts.FindLast(part => part.PartId > 1400 &&
                                     part.PartId < 1500);
            Console.WriteLine(partItem2 != null ? $"Found: last item is {partItem2}"
                                               : "no item found >=1400 && < 1500");

            // With FindLastIndex, the Array is searched backward and returns the
            // list index value of the first item that matches the lambda
            // expression. As with FindIndex, if an item is found, an integer >= 0
            // is returned. If an item is not found, -1 is returned

            int i3 = parts.FindLastIndex(part => part.PartId > 1400 &&
                         part.PartId < 1500);
            Console.WriteLine(i >= 0 ? $"Found: last item at index {i2} is {parts[i2]}"
                                     : "no item found >=1400 && < 1500");

        }

        private static void FindingAllObjectsWithinList(List<Part> parts)
        {
            // Returning all object/items
            //
            // FindAll uses a Lamda expression to look for something in the list
            // - returns all the items in the result set
            // - the result set is based on the lambda expression
            // - it returns an empty list
            //

            Console.WriteLine("Seat Parts");
            List<Part> seats = parts.FindAll(part => part.PartName.Contains("seat"));
            foreach (Part aPart in seats)
            {
                Console.WriteLine(aPart);
            }


            Console.WriteLine("Part in the 1400-1499 range");
            List<Part> partsRange = parts.FindAll(part => part.PartId>=1400 && part.PartId<1500);
            foreach (Part aPart in partsRange)
            {
                Console.WriteLine(aPart);
            }

        }
    }
}
