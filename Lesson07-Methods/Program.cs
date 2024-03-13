using System;

namespace Module1.Lesson7.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = Add(2,3);
            Console.WriteLine(total);
        }



        // ///////////////////////////////////////////////////////////////////////
        //
        // Methods
        //
        // - A method is a code block that contains a series of statements. 
        // - Methods are declared by:
        //      specifying the access level such as public or private,
        //      the return value, 
        //      the name of the method, 
        //      and any method parameters. 
        //
        //      These parts together are the signature of the method.

        // example: the following method is public, doesn't return anything,
        // name is DisplayHello and has no parameters
        static public void DisplayHello()
        {
            Console.WriteLine("Hello World!");
        }

        // another example: the following is public, returns an integer,
        // name is Add and has two integer parameters

        static public int Add(int number1, int number2)
        {
            var total = number1 + number2;
            return total;
        }

    }
}
