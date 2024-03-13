namespace Module3.Lesson12.DefineAndUsingClasses
{

    class Pet
    {
        public Pet(string name, int numberOfLegs)
        {
            Name = name;
            NumberOfLegs = numberOfLegs;
        }

        public string Name { get; set; }
        public int NumberOfLegs { get; set; }
    }
}
