using System;

namespace Module1.Lesson5.EnumsAndStructs
{

    class Program
    {
        static void Main(string[] args)
        {
            //Enumerators();
            //EnumAsFlags();
            StructExample1();
            StructExample2();
        }

        // ///////////////////////////////////////////////////////////////////////
        //
        // Enumerated Types
        //

        enum PersonType
        {
            Student,
            Employee,
            Manager
        }

        static void Enumerators()
        {
            // value type defined by a set of named constants of the underlying 
            // integral numeric type. By default, the associated constant values
            // of enum members are of type int; they start with zero and increase
            // by one following the definition text order.

            PersonType pType = PersonType.Manager;
            Console.WriteLine(pType);
            Console.WriteLine(pType.ToString());
            Console.WriteLine(Convert.ToInt32(pType));

            // output
            //
            // Manager
            // Manager
            // 2
        }

        // Enumerated Types, if undefined, start at 0 and increment by 1
        //
        // However, you can assign a value to each enum constant value
        // as shown below
        enum Color
        {
            Black = 10,
            White = 20,
            Red = 30,
            Blue = 40
        }

        // Enumeration types as bit flags
        //
        // If you want an enumeration type to represent a combination of choices, 
        // define enum members for those choices such that an individual choice is 
        // a bit field.That is, the associated values of those enum members should 
        // be the powers of two.Then, you can use the bitwise logical operators | or & 
        // to combine choices or intersect combinations of choices, respectively.
        // To indicate that an enumeration type declares bit fields, apply the Flags 
        // attribute to it. As the following example shows, you can also include some 
        // typical combinations in the definition of an enumeration type.
        //
        // for example:
        //

        [Flags]
        public enum Days
        {
            None =      0b_0000_0000,   // 0
            Monday =    0b_0000_0001,   // 1
            Tuesday =   0b_0000_0010,   // 2
            Wednesday = 0b_0000_0100,   // 4
            Thursday =  0b_0000_1000,   // 8
            Friday =    0b_0001_0000,   // 16
            Saturday =  0b_0010_0000,   // 32
            Sunday =    0b_0100_0000,   // 64
            Weekend = Saturday | Sunday
        }

        static void EnumAsFlags()
        {
            Days meetingDays = Days.Monday | Days.Wednesday | Days.Friday;
            Console.WriteLine(meetingDays);
            // Output:
            // Monday, Wednesday, Friday

            Days workingFromHomeDays = Days.Thursday | Days.Friday;
            Console.WriteLine($"Join a meeting by phone on {meetingDays & workingFromHomeDays}");
            // Output:
            // Join a meeting by phone on Friday

            bool isMeetingOnTuesday = (meetingDays & Days.Tuesday) == Days.Tuesday;
            Console.WriteLine($"Is there a meeting on Tuesday: {isMeetingOnTuesday}");
            // Output:
            // Is there a meeting on Tuesday: False

            var a = (Days)37;
            Console.WriteLine(a);
            // Output:
            // Monday, Wednesday, Saturday
            //
            // because Monday(1) + Wednesday(4) + Saturday(32) = 37
            //
        }

        // ///////////////////////////////////////////////////////////////////////
        //
        // Struct Types
        //
        // Instructor Notes:
        //
        // Structs are value types that cannot be null, the default value of a struct is 
        // the value produced by setting all value type fields to their default value 
        // and all reference type fields to null.
        //
        // simular to reference types, you must instantiate a struct (new)
        //
        // structs are not reference types, it is not possible for values of a struct type
        // to be null
        //
        // Struct types are never abstract and are always implicitly sealed. The abstract 
        // and sealed modifiers are therefore not permitted in a struct declaration.
        //
        // when a struct is passed as a value parameter or returned as the result of a 
        // function member, a copy of the struct is created. A struct may be passed by 
        // reference to a function member using a ref or out parameter.

        public struct Point
        {
            public int X;
            public int Y;
        }

        public static void StructExample1()
        {
            Point start = new Point();
            start.X = 10;
            start.Y = 15;

            Console.WriteLine($"x: {start.X} y: {start.Y}"); ;
        }

        // more instructor notes
        //
        // structs can have a constructor
        // struct is not permitted to declare a parameterless instance constructor. 
        // Instead, every struct implicitly has a parameterless instance constructor 
        // which always returns the value that results from setting all value type fields 
        // to their default value and all reference type fields to null
        //
        // struct inherents from System.ValueType which inherents from object... so the
        // ToString() can be overridden
        //


        public struct GraphPoint
        {
            public int x, y;

            public GraphPoint(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public override string ToString()
            {
                return $"x: {x} y: {x}";
            }
        }

        public static void StructExample2()
        {
            GraphPoint p1 = new GraphPoint();
            GraphPoint p2 = new GraphPoint(0, 0);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());

            // output
            //
            // x: 0 y:0
            // x: 0 y:0


            // instructor notes
            //
            //
            // The assignment of a to b creates a copy of the value, and b is 
            // thus unaffected by the assignment to a.x.
            
            GraphPoint a = new GraphPoint(10, 10);
            GraphPoint b = a;

            a.x = 100;
            Console.WriteLine(b.x);

            // output 
            //
            // 10

            // Note: Had GraphPoint instead been declared as a class, the output 
            // would be 100 because a and b would reference the same object.

        }

    }

    



}
