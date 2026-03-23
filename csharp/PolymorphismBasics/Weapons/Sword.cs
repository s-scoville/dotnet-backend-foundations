namespace PolymorphismBasics.Weapons
{
    public class Sword : Weapon
    {
        public int SlashDamage { get; }
        public Sword(string name, double weight, string material, int baseDamage, int slashDamage) : base(name, weight, material, baseDamage)
        {
            SlashDamage = slashDamage;
        }
    }
}
