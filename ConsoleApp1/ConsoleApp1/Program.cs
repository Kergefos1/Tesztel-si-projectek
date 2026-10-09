// Egyik

using ConsoleApp1;

Flight flight1 = new Flight("Szia", "Mia", 122000, 3);
Flight flight2 = new Flight("Szia", "Mia", 122000, 1);

flight2.BookSeats();
Console.WriteLine(flight2.FreeSeats);
flight2.BookSeats();
Console.WriteLine(flight2.FreeSeats);

flight1.Describe();
flight2.Describe();



//