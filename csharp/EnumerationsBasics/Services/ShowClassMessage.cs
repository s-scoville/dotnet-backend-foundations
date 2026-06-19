using EnumerationsBasics.Models;

namespace EnumerationsBasics.Services
{
    public class ShowClassMessage
    {
        public void Display(ClassType classType)
        {
            switch (classType)
            {
                case ClassType.Warrior:
                    Console.WriteLine("You are a mighty Warrior!");
                    break;
                case ClassType.Mage:
                    Console.WriteLine("You are a powerful Mage!");
                    break;
                case ClassType.Rogue:
                    Console.WriteLine("You are a stealthy Rogue!");
                    break;
                case ClassType.Hunter:
                    Console.WriteLine("You are a skilled Hunter!");
                    break;
                case ClassType.Paladin:
                    Console.WriteLine("You are a noble Paladin!");
                    break;
                default:
                    Console.WriteLine("Unknown class type!");
                    break;
            }
        }
    }
}