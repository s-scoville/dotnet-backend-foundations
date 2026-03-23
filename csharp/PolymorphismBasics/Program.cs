using PolymorphismBasics.Weapons;

List<Weapon> weapons = new List<Weapon>();
weapons.Add(new Sword("Copper Sword", 10, "Copper", 5, 5));
weapons.Add(new Bow("Wooden Bow", 6, "Wood", 5, 10));
weapons.Add(new Mace("Iron Mace", 15, "Iron", 10, 20));

foreach (Weapon w in weapons)
{
    w.Attack();
}