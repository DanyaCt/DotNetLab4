using DotNetLab4.Trips;
using DotNetLab4.Vehicles;

namespace DotNetLab4.TripDecorators
{
    internal class BicycleTripDecorator : BasicTripDecorator
    {
        public BicycleTripDecorator(ITrip wrappee, float distance)
            : base(wrappee, distance)
        {
            _vehicle = new Bicycle();
        }
    }
}
