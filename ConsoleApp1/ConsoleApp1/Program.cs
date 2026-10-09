//Másik

using ConsoleApp1;
using System.Reflection.Metadata;

Passenger passenger1 = new Passenger("feri", 11, 5);
Passenger passenger2 = new Passenger("toli", 21, 3);

passenger2.AddBag();
passenger2.AddBag();
passenger2.AddBag();

Console.WriteLine(passenger1.Name);
Console.WriteLine(passenger2.Name);
Console.WriteLine(passenger1.Age);
Console.WriteLine(passenger2.Age);
Console.WriteLine(passenger1.BagCount);
Console.WriteLine(passenger2.BagCount);
Console.WriteLine(passenger1.IsChild());
Console.WriteLine(passenger2.IsChild());
