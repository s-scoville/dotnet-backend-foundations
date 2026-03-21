namespace InheritanceBasics.Animals
{
    public class Cat : Animal
    {
        public bool IsDeclawed { get; private set; }
        public Cat (string name, int age, double weight, string breed, bool isDeclawed): base (name, age, weight, breed)
        {
            IsDeclawed = isDeclawed;
        }
    }
}
