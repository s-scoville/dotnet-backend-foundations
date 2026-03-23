namespace PolymorphismBasics.Weapons
{
    public class Mace : Weapon
    {
        public int BluntDamage { get; }

        public Mace(string name, double weight, string material, int baseDamage, int bluntDamage): base(name, weight, material, baseDamage)
        {
            BluntDamage = bluntDamage;
        }

        public override void Attack()
        {
            Console.WriteLine($"You crush the enemy for {BaseDamage + BluntDamage} damage.");
        }
    }
}
