using System;

namespace Module2.Lesson11.Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Why we need to debug
            // 
            //     - the compiler catches and forces us to fix compile time errors
            //     - logical errors and run time errors occur when the app runs
            //
            //     - we can run the program and have it stop at certain points in code
            //

            // example: 
            
            //  -   place a breakpoint on the line below where the variable
            //      message is defined.
            //  -   run the program
            //  -   notice that the program stops running on this line
            //  -   note that the message vaiable is null, step over the line and
            //      then notice that the variable now has a value 'Hello World'
            //
            var message = "Hello World";
            Console.WriteLine(message);

        }
    }
}
