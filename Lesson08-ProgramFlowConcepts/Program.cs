using System;

namespace Module2.Lesson8.ProgramFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Flow");
            SwitchStatement();
        }


        static void IfStatement()
        {
            int age = 17;

            // The if statement: selects a statement to execute 
            // based on the value of a Boolean expression.
            //
            // An if statement can be any of the following two forms
            //
            //      if (boolean condition is true) 
            //      {
            //          execute these statements
            //      }
            //

            if (age == 17)
            {
                Console.WriteLine("Age is 17");
            }

            // the other form can be ...
            //
            // An if statement with an else part selects one of the two statements 
            // to execute based on the value of a Boolean expression, as the following 
            // example shows:
            //

            var ageDescription = "";
            if (age == 17)
            {
                ageDescription = "Age is 17";
            } else
            {
                ageDescription = "Other";
            }
            Console.WriteLine(ageDescription);


            ageDescription = age == 17 ? "Teenager" : "Other";
            Console.WriteLine(ageDescription);

        }

        static void ConditionalOperator()
        {
            // The conditional operator ?:, also known as the ternary conditional operator, 
            // evaluates a Boolean expression and returns the result of one of the two 
            // expressions, depending on whether the Boolean expression evaluates to 
            // true or false, as the following example shows:

            Console.WriteLine(GetWeatherDisplay(15));  
            Console.WriteLine(GetWeatherDisplay(27));  // output: Perfect!

            string GetWeatherDisplay(double tempInCelsius)
            {
                // the syntax for the conditional operator is as follows:
                //
                //   condition ? consequent : alternative
                // 
                //   in other words...
                //
                //   (boolean expression) ? expression is true : expression is false
                //

                var result = tempInCelsius < 20.0 ? "Cold." : "Perfect!";

                return result;
            }

            // output:
            //
            // Cold.
            // Perfect!.


        }

        static void SwitchStatement()
        {

            // The switch statement selects a statement list to execute 
            // based on a pattern match with a match expression
            //
            // the switch statement uses the following patterns:
            //
            //      - A relational pattern: to compare an expression result 
            //        with a constant.
            //      - A constant pattern: to test if an expression result 
            //        equals a constant.

            DisplayMeasurement1(-4);  
            DisplayMeasurement1(5);  
            DisplayMeasurement1(30);  
            DisplayMeasurement1(double.NaN);

            // Output: value too low.
            // Output: value is 5.
            // Output: value is too high.
            // Output: Failed measurement.

            void DisplayMeasurement1(double measurement)
            {
                switch (measurement)
                {
                    case < 0.0:
                        Console.WriteLine("value is too low.");
                        break;

                    case > 15.0:
                        Console.WriteLine("value is too high.");
                        break;

                    case double.NaN:
                        Console.WriteLine("Failed measurement.");
                        break;

                    default:
                        Console.WriteLine($"value is {measurement}.");
                        break;
                }
            }

            // The default case specifies statements to execute when a 
            // match expression doesn't match any other case pattern. 
            //
            // If a match expression doesn't match any case pattern and
            // there is no default case ... control falls through a switch statement.


            // You can specify multiple case patterns for one section of a 
            // switch statement, as the following example shows

            DisplayMeasurement2(-4);  
            DisplayMeasurement2(50);  
            DisplayMeasurement2(132);

            void DisplayMeasurement2(int measurement)
            {
                switch (measurement)
                {
                    case < 0:
                    case > 100:
                        Console.WriteLine($"Measured value is {measurement}; out of an acceptable range.");
                        break;

                    default:
                        Console.WriteLine($"Measured value is {measurement}.");
                        break;
                }
            }

            // Output: Measured value is -4; out of an acceptable range.
            // Output: Measured value is 50.
            // Output: Measured value is 132; out of an acceptable range.


        }
    }
}
