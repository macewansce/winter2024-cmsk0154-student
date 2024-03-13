using System;

namespace Module2.Lesson10.DoAndWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void DoStatement()
        {
            // The do statement executes a statement or a block of statements while 
            // a specified Boolean expression evaluates to true. Because that expression 
            // is evaluated after each execution of the loop, a do loop executes one or 
            // more times. This differs from a while loop which executes zero or more times.
            // We'll discuss the whle loop shortly.

            int n = 0;
            do
            {
                Console.Write(n);
                n++;

            } while (n < 5);
            // Output:
            // 01234

            // **** Notice that the condition to determine if anything is executed
            // AFTER we execute the statements once

        }

        static void WhileStatement()
        {
            // The while statement executes a statement or a block of statements 
            // while a specified Boolean expression evaluates to true.Because that 
            // expression is evaluated before each execution of the loop, a while 
            // loop executes zero or more times.This differs from a do loop, 
            // which executes one or more times.

            int n = 0;
            while (n < 5)
            {
                Console.Write(n);
                n++;
            }
            // Output:
            // 01234

            // **** Notice that the condition to determine if anything is executed
            // BEFORE we execute any of the statements

        }
    }
}
