using DotNetLab4.Trips;
using DotNetLab4.Vehicles;

namespace DotNetLab4.TripDecorators
{
    internal class HorseTripDecorator : BasicTripDecorator
    {
        public HorseTripDecorator(ITrip wrappee, float distance)
            : base(wrappee, distance)
        {
            _vehicle = new Horse();
        }
    }
}
