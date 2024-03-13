using System;

namespace Lesson16_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void ArrayFundamentals()
        {
            // You can store multiple variables of the same type in an 
            // array data structure. You declare an array by specifying the 
            // type of its elements. 

            // basic structure : type[] arrayName;

            ///////////////////////////////////////////////////////////////////
            //

            // Declare a single-dimensional array of 5 integers.
            int[] array1 = new int[5];

            // Declare and set array element values.
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            // Alternative syntax.
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            ///////////////////////////////////////////////////////////////////
            //

            // Declare a two dimensional array.
            int[,] multiDimensionalArray1 = new int[2, 3];

            // Declare and set array element values.
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Declare a jagged array.
            int[][] jaggedArray = new int[6][];

            // Set the values of the first array in the jagged array structure.
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };


            ///////////////////////////////////////////////////////////////////
            //
            //   Array overview
            //

            // An array has the following properties:

            // - An array can be single - dimensional, multidimensional or jagged.
            //
            // - The number of dimensions and the length of each dimension are 
            //   established when the array instance is created.These values can't 
            //   be changed during the lifetime of the instance.
            //
            // - The default values of numeric array elements are set to zero, 
            //   and reference elements are set to null.
            //
            // - A jagged array is an array of arrays, and therefore its elements 
            //   are reference types and are initialized to null.
            //
            // - Arrays are zero indexed: an array with n elements is indexed 
            //   from 0 to n-1.
            //
            // - Array elements can be of any type, including an array type.
            //
            // - Array types are reference types derived from the abstract base 
            //   type Array.All arrays implement IList, and IEnumerable. 
            //   You can use the foreach statement to iterate through an array. 
            //
            // - Single-dimensional arrays also implement IList<T> and IEnumerable<T>.
            //
        }

        static void SingleDimentionArrays()
        {
            // You create a single-dimensional array using the new operator 
            // specifying the array element type and the number of elements. 
            //
            //The following example declares an array of five integers:

            int[] array = new int[5];

            // This array contains the elements from array[0] to array[4]. 
            // The elements of the array are initialized to the default value 
            // of the element type, 0 for integers.

            // Arrays can store any element type you specify, such as the 
            // following example that declares an array of strings:

            string[] stringArray = new string[6];

            ///////////////////////////////////////////////////////////////////
            //
            // Retreving data from Array

            // You can retrieve the data of an array by using an index. For example:

            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            Console.WriteLine(weekDays[0]);
            Console.WriteLine(weekDays[1]);

            // Output:
            
            // Sun
            // Mon
        }

        static void MultiDimentionArrays()
        {
            ///////////////////////////////////////////////////////////////////
            //
            // Multidimensional Arrays

            // Arrays can have more than one dimension.For example, the 
            // following declaration creates a two - dimensional array of 
            // four rows and two columns.

            int[,] array = new int[4, 2];


            // The following declaration creates an array of three 
            // dimensions, 4, 2, and 3.

            int[,,] array1 = new int[4, 2, 3];


            ///////////////////////////////////////////////////////////////////
            //
            // Array Initialization

            // You can initialize the array upon declaration, as is shown 
            // in the following example.


            // Two-dimensional array.
            int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            // The same array with dimensions specified.
            int[,] array2Da = new int[4, 2] { 
                { 1, 2 }, 
                { 3, 4 }, 
                { 5, 6 }, 
                { 7, 8 } 
            };

            // A similar array with string elements.
            string[,] array2Db = new string[3, 2] { 
                { "one", "two" }, 
                { "three", "four" },
                { "five", "six" } 
            };

            // Three-dimensional array.
            int[,,] array3D = new int[,,] { 
                { 
                    { 1, 2, 3 }, 
                    { 4, 5, 6 } 
                },
                { 
                    { 7, 8, 9 }, 
                    { 10, 11, 12 } 
                } 
            };

            // The same array with dimensions specified.
            int[,,] array3Da = new int[2, 2, 3] { 
                { 
                    { 1, 2, 3 }, 
                    { 4, 5, 6 } 
                },
                { 
                    { 7, 8, 9 }, 
                    { 10, 11, 12 } 
                } 
            };

            ///////////////////////////////////////////////////////////////////
            //
            // Retreving data from Multi-Multidimensional Array

            Console.WriteLine(array2Db[1, 0]);
            Console.WriteLine(array3Da[1, 0, 1]);

        }


        static void JaggedArrays()
        {
            ///////////////////////////////////////////////////////////////////
            //
            // Multidimensional Arrays

            // A jagged array is an array whose elements are arrays, possibly 
            // of different sizes. They are sometimes called an "array of arrays." 
            // The following examples show how to declare, initialize, and 
            // access jagged arrays.

            // The following is a declaration of a single - dimensional array 
            // that has three elements, each of which is a single - dimensional 
            // array of integers:

            int[][] jaggedArray = new int[3][];

            // Before you can use jaggedArray, its elements must be initialized.
            // You can initialize the elements like this:

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[2];

            // Each of the elements is a single - dimensional array of integers.
            // The first element is an array of 5 integers, the second is an array 
            // of 4 integers, and the third is an array of 2 integers.

            // You can also initialize the array upon declaration like this:

            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 22 }
            };

            // or ...

            int[][] jaggedArray3 =
            {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 22 }
            };


            ///////////////////////////////////////////////////////////////////
            //
            // Retreving data from Jagged Array

            Console.Write("{0}", jaggedArray3[0][2]);   // returns 5
            Console.WriteLine(jaggedArray3.Length);     // returns 3


            ///////////////////////////////////////////////////////////////////
            //
            // Using foreach with arrays

            // The foreach statement provides a simple, clean way to iterate 
            // through the elements of an array.

            // For single-dimensional arrays, the foreach statement processes 
            // elements in increasing index order, starting with index 0 and 
            // ending with index Length - 1:

            int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
            foreach (int i in numbers)
            {
                System.Console.Write("{0} ", i);
            }
            // Output: 4 5 6 1 2 3 -2 -1 0
        }
    }
}
