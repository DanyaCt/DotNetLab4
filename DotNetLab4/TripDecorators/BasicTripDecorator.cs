using DotNetLab4.Trips;
using DotNetLab4.Vehicles;

namespace DotNetLab4.TripDecorators
{
    internal abstract class BasicTripDecorator : ITrip
    {
        private protected IVehicle _vehicle;
        private ITrip _wrappee;
        public float Distance { get; set; }
        public TripType Type { get; }
        protected BasicTripDecorator(ITrip wrappee, float distance)
        {
            _wrappee = wrappee;
            Distance = distance;
            Type = wrappee.Type;
        }

        public decimal GetTripPrice()
        {
            var priceOfDecorator = Type == TripType.Passenger
                ? (decimal)Distance * _vehicle.PassengerTransportationPrice
                : (decimal)Distance * _vehicle.GoodsTransportationPrice;
            return priceOfDecorator + _wrappee.GetTripPrice();
        }

        public float GetTripDuration()
        {
            var durationOfDecorator = Distance / _vehicle.AverageSpeed;
            return durationOfDecorator + _wrappee.GetTripDuration();
        }
    }
}
