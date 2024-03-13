using System;
using System.Collections.Generic;

namespace Module3.Lesson12.Polymorphism
{
    /************************************************************************
     
        This example is purposely placing all of the classes in one file
        so that the instructor can walk through Polymorphism step by step...

        It is best practice to place classes in their own files
    */

    // 
    // Polymorphism describes a pattern in object oriented programming in which 
    // classes have different functionality while sharing a common interface.
    //
    // In other words, when a derived class overrides the behaviour of the base class
    //
    // Example:
    
    class Animal
    {
        public string Name { get; set; }

        // Our animal class has a method called Speak and it is declared as virtual
        // Using virtual, we are allowing derived classes to 'override' this method
        // and change how this method will work - we are, effectively, changing
        // the behaviour of this class. To demonstrate polymorphism, we first need
        // to define the method os virtual

        // Step 1: define the Speak method as virtual
        public virtual void Speak()
        {
            Console.WriteLine($"The {Name} Grunts!");
        }
    }

    // step 2: create a new class that inherents from Animal
    //

    class Dog : Animal
    {
        // Our new Dog Type is 'inherenting' from Animal so all of the members
        // (the Name property and Speak() method) are available (inherented)

        // Step 2.1
        //
        // Without including any members in the Dog class, demonstrate this
        // by creating an instance of Dog, assigning the Name property a value, and
        // 
        //      static void Main(string[] args)
        //      {
        //          Animal animal = new Animal();
        //          animal.Name = "Animal";
        //          animal.Speak();
        //      }
        //
        //      // output: The Animal Grunts!

        // Step 2.2
        //
        // Since the Dog Type is a dog, create a constructor that will 
        // assign the Name property of the inherented Animal class 'Dog'
        //
        public Dog()
        {
            Name = "Dog";
        }

        // Step 3: override the Speak() method so that when Speak() is called
        // on a Dog object, Speak() will output "Woof!"
        //
        public override void Speak()
        {
            Console.WriteLine($"The {Name} says Woof!");
        }
    }

    // Step 4: Access base class virtual members from derived classes
    //
    // A derived class that has overridden a method can still access the method 
    // on the base class using the 'base' keyword.
    // The following code provides an example:
    //

    class Cat: Animal
    {
        public Cat()
        {
            Name = "Cat";
        }

        public override void Speak()
        {
            //base.Speak();
            Console.WriteLine($"The {Name} says Meow!");

            // In the main method, add the following to see the results
            //
            //
            // Output:
            //
            //    Cat fluffy = new Cat();
            //    fluffy.Speak();
            //    
            // The Cat Grunts!
            // The Cat says Meow!
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog spike = new Dog();
            spike.Speak();

            // The 'Is a' rule
            //

            // the following is an error because an Animal is not a Dog
            //       Animal 'Is a' Dog ....  this is false
            //
            //Dog ben = new Animal();
            //ben.Speak();

            // But... a Dog 'Is a' Animal because a dog inherits from an Animal
            Animal ben = new Dog();
            ben.Speak();

            // Question to the class... what will ben.Speak() output?
            // 
            // run and demonstrate this...


            // Why would we do this?
            //
            // If you wanted to have one list of dogs and cats (and other objects)
            // we run into a problem
            // 
            // if you create a list of dogs you can't add cats, or visa-versa
            //     List<Dog> dogs = new List<Dog>();
            //     dogs.Add(new Dog());
            //     dogs.Add(new Cat()); // error
            // So, how can we have one list with different objects....
            // you create the list based on the Base Class (Animal)

            // as the following:
            //
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog());
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Dog());

            // then you could list them out like this...

            foreach(var animal in animals)
            {
                animal.Speak();
            }

            // NOTE: before running this step 5, comment out the base.Speak()
            // in the Cat class

        }
    }
}
