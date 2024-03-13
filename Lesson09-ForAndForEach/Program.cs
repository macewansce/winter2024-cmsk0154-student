using System;
using System.Collections.Generic;

namespace Module2.Lesson09.ForAndForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ForEachStatement();
        }

        static void ForStatement()
        {
            // The for statement executes a statement or a block of statements 
            // while a specified Boolean expression evaluates to true
 
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i);
            }
            // Output:
            // 012

            // there are three elements in the for statement:
            //
            // initializer, condition, incrementor
            //
            //      for (initializer; condition; incrementor)
            //      { 
            //
            //          statment to execute in each iteration of the loop }
            //
            //      }

            // The initializer section that is executed only once, before entering 
            // the loop. Typically, you declare and initialize a local loop variable 
            // in that section. The declared variable can't be accessed from outside 
            // the for statement.
            //
            // The condition section that determines if the next iteration in the loop 
            // should be executed. If it evaluates to true or is not present, the next 
            // iteration is executed; otherwise, the loop is exited. The condition section
            // must be a Boolean expression.
            //
            // The iterator section: that defines what happens after each 
            // execution of the body of the loop. In the example above: i++
        }

        static void ForEachStatement()
        {
            // The foreach statement executes a statement or a block of 
            // statements for each element in an array or collection
            //
            // NOTE: for simplicity... the definition above notes 'an array or collection'
            // but it's actually anything that implements the IEnumerable or 
            // IEnumerable<T> interface

            var numbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
            foreach (int number in numbers)
            {
                if (number == 1) continue;
                if (number == 8) break;
                Console.Write($"{number} ");
            }
            // Output:
            // 0 1 1 2 3 5 8 13
        }

        static void ContinueAnBreak()
        {
            // The continue statement passes control to the next iteration 
            // of the enclosing
            //

            // the break statement will immeditately exit the foreach statement
            //
            var numbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
            foreach (int number in numbers)
            {
                // if the current iterator variable 'number' is equal to 1,
                // then the 'continue' statement is exectuted which immediately returns
                // to the top the of foreach statement - the iterator section is then
                // executed - effectively... get the next item 
                //
                if (number == 1) continue;

                // if the number is equal to 8 then the break statement is executed
                // and the 'break' is executed - when immediately exits the foreach
                //
                if (number == 8) break;
                Console.Write($"{number} ");
            }
            // Output:
            // 0 2 3 5

        }
    }
}
