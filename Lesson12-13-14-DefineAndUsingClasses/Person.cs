using System;

namespace Module3.Lesson12.DefineAndUsingClasses
{
    // In the example below, we are defining a new Type - a Person Type.
    // Everything inside the { and } defines the 'state' and 'behavior' of the class.
    // 
    //      class Person
    //      {
    //          // state and behaviour of the class 
    //      }

    // state simply means variables (fields and properties) that hold data
    // bevaviour simply are the methods (functions) that do something

    class Person
    {
        // This is a field (state)
        //
        // Fields are typically private variables that hold data
        // that ONLY the class can read and stores values
        // (more about private variables versus public variables later
        private string _firstName;
        private string _lastName;

        // This is a Property (state)
        //
        // Properties are data elements and can have code that enforces 
        // validation or other rules.
        //
        // Propeties look simular to how fields are define but with two special
        // method-looking functions inside of it; a getter (get) and a setter (set)
        //      The 'getter' returns the current value of a class field (_firstName)
        //      The 'setter' allows the class field (_firstName) to be assigned

        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName ?? "N/A";
            set {
                if (value==null)
                    throw new ArgumentOutOfRangeException(
                   $"{nameof(value)} cannot be null");
                _lastName = value;
            }
        }

        // Auto-implemented properties
        public string PhoneNumber { get; set; }

        // Methods (Behaviour)

        // Methods can:
        //
        // have a return type
        // have parameters
        // have access modifiers
        // 
        // ... all the same variations as described in lesson 7

        public void OutputDetails()
        {
            Console.WriteLine($"{LastName}, {FirstName} : {PhoneNumber}");
        }

    }
}
