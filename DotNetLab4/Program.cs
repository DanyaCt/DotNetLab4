using DotNetLab4;

try
{
    var menu = new Menu();
    var trip = menu.GetTrip();
    Console.WriteLine($"It costs you: {trip.GetTripPrice()}$ for {trip.GetTripDuration()} hours");
    while (true)
    {
        Console.WriteLine("Do you want to continue your trip?");
        Console.WriteLine("1.Yes\n2.No");
        var key = Console.ReadKey().KeyChar;
        if (key == '2')
            Environment.Exit(0);

        var decoratedTrip = menu.DecorateTrip(trip);

        Console.WriteLine($"\nIt costs you: {decoratedTrip.GetTripPrice()}$ for {decoratedTrip.GetTripDuration()} hours\n");
        trip = decoratedTrip;
    }
}
catch (ArgumentException e)
{
    Console.WriteLine();
    Console.WriteLine(e.Message);
}
