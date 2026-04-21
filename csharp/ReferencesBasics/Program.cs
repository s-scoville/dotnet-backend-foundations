using ReferencesBasics.Models;

Vehicle vehicle1 = new Vehicle(0);
Vehicle vehicle2 = vehicle1;

Console.WriteLine("Reference Type Demonstration:");
Console.WriteLine($"Before change - vehicle1.Speed: {vehicle1.Speed}");
Console.WriteLine($"Before change - vehicle2.Speed: {vehicle2.Speed}");
Console.WriteLine();

vehicle2.Speed = 5;
Console.WriteLine("After modifying vehicle2.Speed to 5:");
Console.WriteLine($"After change - vehicle1.Speed: {vehicle1.Speed}");
Console.WriteLine($"After change - vehicle2.Speed: {vehicle2.Speed}");
Console.WriteLine();