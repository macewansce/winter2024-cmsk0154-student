using System;

namespace Module3.Lesson12.DefineAndUsingClasses
{
    // Lesson 12 Instruction step-by-step 

    //  1. Defining a Class ( Person.cs file )
    //  2. Creating Objects ( CreatingObjects() Method )
    //  3. Constructors ( Pet.cs file )
    //      a) Using contructors ( CreatingObjectsWithConstructors() Method )
    
    //
    //  4. Access Modifiers



    class Program
    {
        static void Main(string[] args)
        {
            CreatingObjects();
        }

        static void CreatingObjects()
        {
            // a) The Person class defines a "Type"; Person is a Type
            // b) An object is 'instance of a type', therefore, to create
            //    a Person object, we must create a 'new' instance of the
            //    Person type

            Person allan = new Person();

            // the variable allan is defined as an instance of a Person type
            // this is a reference variable and therefore stored on the Heap

            // to assign values to the members of the person object, we
            // do this as follows:

            allan.FirstName = "Allan";
            allan.LastName = "Levsen";
            allan.PhoneNumber = "780.424.1234";

            allan.OutputDetails();

            // another way we can assign members values is as follows

            Person karen = new Person
            {
                FirstName = "Karen",
                LastName = "Anderson",
                PhoneNumber = "780.955.4567"
            };

            karen.OutputDetails();

            // Output:
            
            // Levsen, Allan: 780.424.1234
            // Anderson, Karen: 780.955.4567
        }

        static void CreatingObjectsWithConstructors()
        {
            Pet dog = new Pet("Dog", 4);
            Pet cat = new Pet("Cat", 4);
            Pet bird = new Pet("Bird", 2);
        }


    }
}
