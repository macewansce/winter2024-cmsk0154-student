using System;
using System.Collections;
using System.Collections.Generic;

namespace Module4.Lesson20.Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {

            // Dictionaries represent a collection of keys and values.
            //
            // Dictionary<TKey, TValue>
            //
            //      TKey    - The type of the keys in the dictionary.
            //      TValue  - The type of the values in the dictionary.
            //
            // The Dictionary<TKey,TValue> generic class provides a mapping from a 
            // set of keys to a set of values. Each addition to the dictionary consists 
            // of a value and its associated key. Retrieving a value by using its key 
            // is very fast because the Dictionary<TKey,TValue> class is implemented 
            // as a hash table.
            //
            //  - Every key in a Dictionary<TKey,TValue> must be unique according to the 
            //    dictionary's equality comparer. 
            //  - A key cannot be null, but a value can be, if its type TValue is a 
            //    reference type.
            //


            /////////////////////////////////////////////////////////////////////////////
            //
            // Defining a new Dictionary
            //

            // Create a new dictionary of string keys and string values.
            //
            Dictionary<string, string> provinces = new Dictionary<string, string>();

            // Dictionary<string, string>:
            // 
            //  - the first string declaration is defining the type of the key
            //  - the second string declaration is defining the type of the value
            //
            //  so, the data would look like: "AB" (key) and "Alberta" (value)
            //

            // Create a new dictionary of integer keys and string values .
            //
            Dictionary<int, string> months = new Dictionary<int, string>();

            //
            //  so, the data would look like: 5 (key) and "May" (value)
            //


            /////////////////////////////////////////////////////////////////////////////
            //
            // Adding data to a Dictionary
            //

            provinces.Add("BC", "British Columbia");
            provinces.Add("AB", "Alberta");
            provinces.Add("SK", "Saskatchewan");

            // or

            months.Add(1, "January");
            months.Add(2, "February");
            months.Add(3, "March");

            // you can, also, add or change a value in the dictionary using
            // the index of an item
            
            //     - if the key doesn't exist, a new item is added 
            //     - if the key exists, then the value is changed

            // add a new item because the key 4 doesn't exist
            months[4] = "April";

            // changes the value associated to key 2
            months[2] = "Very Cold Month";


            foreach (var month in months)
                Console.WriteLine(month);


            /////////////////////////////////////////////////////////////////////////////
            //
            // Removing data from a Dictionary
            //

            // To remove an item in the dictionary, use the Remove method
            //

            months.Remove(2);
            provinces.Remove("SK");

            //
            // - If the dictionary does not contain an item with the specified key, 
            //   the dictionary remains unchanged. No exception is thrown.
            // - Remove returns true if the key is found and the item is removed. 
            // - Remove returns false if key is not found.
            // - An exception error is thrown if the key is null
            // - Remove is very fast
            //

            // clears (empties) the entire list
            //
            months.Clear();
            provinces.Clear();


            /////////////////////////////////////////////////////////////////////////////
            //
            // Getting data from a Dictionary
            //

            // add values for testing...
            //
            provinces.Add("BC", "British Columbia");
            provinces.Add("AB", "Alberta");
            provinces.Add("SK", "Saskatchewan");
            months.Add(1, "January");
            months.Add(2, "February");
            months.Add(3, "March");


            // counting the items

            var totalMonths = months.Count;
            Console.WriteLine($"There are {totalMonths} items in the 'months' dictionary!");

            // output
            //
            //  There are 3 items in the 'months' dictionary!


            // getting items from the dictionary
            //
            // to get values from the dictionary you can use the following methods
            //

            // using the index property and a key 
            //
            var month1 = months[1];                 // January

            // var month10 = months[10];            // exception error!

            var saskProv = provinces["SK"];         // Saskatchewan 
            // var ontarioProv = provinces["ON"];   // exception error!

            bool hasJanuary = months.ContainsValue("January");  // true
            bool hasJune = months.ContainsValue("June");        // false

            bool hasBC = provinces.ContainsKey("BC");           // true
            bool hasOT = provinces.ContainsValue("OT");         // false


            // we can use TryGetValue to avoid exception errors on keys that
            // don't exist 
            //
            string ontario = null;              
            bool foundOntario = provinces.TryGetValue("OT", out ontario);

            // or, using an if statement
            if (provinces.ContainsValue("OT"))
                ontario = provinces["OT"];



        }


    }
}
