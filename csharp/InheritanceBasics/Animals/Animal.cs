namespace InheritanceBasics.Animals
{
    public class Animal
    {
        public string Name { get; }
        public int Age { get; private set; }
        public double Weight { get; protected set; }
        public string Breed { get; }

        public Animal (string name, int age, double weight, string breed)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Breed = breed;
        }

        public void Birthday ()
        {
            Age++;
        }

    }
}
