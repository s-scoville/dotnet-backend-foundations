namespace InheritanceBasics.Animals
{
    public class Horse : Animal
    {
        public bool HasShoes { get; private set; }
        public Horse(string name, int age, double weight, string breed, bool hasShoes):base(name, age, weight, breed)
        {
            HasShoes = hasShoes;
        }
    }
}
