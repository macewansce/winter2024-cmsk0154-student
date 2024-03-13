using System;

namespace Module1.Lesson6.ReferenceTypes
{
    class Program
    {
        // strings lesson
        //

        static void Main(string[] args)
        {
            Strings();
        }

        // ///////////////////////////////////////////////////////////////////////
        //
        // String : Reference Type

        //
        static public void Strings()
        {
            // unless assigned a value, strings are null by default
            //
            string name; // name is equal to null

            // string variables are assigned as follows
            //
            name = "Allan";  // "Allan"

            // concatenate string variables
            //
            name = "Allan" + " " + "Levsen";  // "Allan Levsen"

            // string interpelation
            //
            string firstName = "Allan";
            string lastName = "Levsen";

            name = $"First: {firstName} - Last: {lastName}"; 

            // name is equal to "First: Allan - Last: Levsen"

        }



    }
}
