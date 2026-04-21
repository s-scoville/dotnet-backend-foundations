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


int wheels1 = 4;
int wheels2 = wheels1;

Console.WriteLine("Value Type Demonstration:");
Console.WriteLine($"Before change - wheels1: {wheels1}");
Console.WriteLine($"Before change - wheels2: {wheels2}");
Console.WriteLine();

wheels2 = 3;

Console.WriteLine("After modifying wheels2 to 3:");
Console.WriteLine($"After change - wheels1: {wheels1}");
Console.WriteLine($"After change - wheels2: {wheels2}");
Console.WriteLine();
Console.WriteLine("Value types create independent copies, so changes do not affect the original.");