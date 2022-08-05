using DotNetLab4.TripDecorators;
using DotNetLab4.Trips;
using DotNetLab4.Vehicles;

namespace DotNetLab4
{
    public class Menu
    {
        public ITrip GetTrip()
        {
            Console.WriteLine("Hello customer!\nChoose what you want deliver:\n");
            Console.WriteLine("1.People\n2.Goods");
            var key = Console.ReadKey().KeyChar;
            var tripType = key switch
            {
                '1' => TripType.Passenger,
                '2' => TripType.Goods,
                _ => throw new ArgumentException("Wrong key.")
            };

            Console.WriteLine("\nChoose vehicle type:\n");
            Console.WriteLine("1.Car\n2.Horse\n3.Bicycle");
            key = Console.ReadKey().KeyChar;
            IVehicle vehicle = key switch
            {
                '1' => new Car(),
                '2' => new Horse(),
                '3' => new Bicycle(),
                _ => throw new ArgumentException("Wrong key.")
            };

            Console.WriteLine("\nEnter distance:\n");
            var distance = Console.ReadLine();
            if (!float.TryParse(distance, out var parsedDistance))
                throw new ArgumentException("Wrong Distance.");
            return new Trip(vehicle, tripType, parsedDistance);
        }

        public ITrip DecorateTrip(ITrip trip)
        {
            Console.WriteLine("\nEnter distance:\n");
            var distanceForDecorator = Console.ReadLine();
            if (!float.TryParse(distanceForDecorator, out var parsedDistanceForDecorator))
                throw new ArgumentException("Wrong Distance.");

            Console.WriteLine("\nChoose vehicle type:\n");
            Console.WriteLine("1.Car\n2.Horse\n3.Bicycle");
            var key = Console.ReadKey().KeyChar;
            return key switch
            {
                '1' => new CarTripDecorator(trip, parsedDistanceForDecorator),
                '2' => new HorseTripDecorator(trip, parsedDistanceForDecorator),
                '3' => new BicycleTripDecorator(trip, parsedDistanceForDecorator),
                _ => throw new ArgumentException("Wrong key.")
            };
        }
    }
}
