namespace PolymorphismBasics.Weapons
{
    public abstract class Weapon
    {
        public string Name { get; }
        public double Weight { get; }
        public string Material { get; }
        public int BaseDamage { get; }

        public Weapon(string name, double weight, string material, int baseDamage)
        {
            Name = name;
            Weight = weight;
            Material = material;
            BaseDamage = baseDamage;
        }

        public abstract void Attack();

    }
}
