namespace PolymorphismBasics.Weapons
{
    public class Bow : Weapon
    {
        public int PiercingDamage { get; }

        public Bow(string name, double weight, string material, int baseDamage, int piercingDamage): base(name, weight, material, baseDamage)
        {
            PiercingDamage = piercingDamage;
        }

        public override void Attack()
        {
            Console.WriteLine($"You shoot the enemy for {BaseDamage + PiercingDamage} damage.");
        }
    }
}
