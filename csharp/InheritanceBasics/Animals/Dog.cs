namespace InheritanceBasics.Animals
{
    public class Dog : Animal
    {
        public string HairLength { get; private set; }

        public Dog(string name, int age, double weight, string breed, string hairLength) : base(name, age, weight, breed)
        {
            HairLength = hairLength;
        }
    }
}
