using DotNetLab4.Vehicles;

namespace DotNetLab4.Trips
{
    internal class Trip : ITrip
    {
        private readonly IVehicle _vehicle;
        private readonly float _distance;
        public TripType Type { get; }
        public Trip(IVehicle vehicle, TripType type, float distance)
        {
            _vehicle = vehicle;
            Type = type;
            _distance = distance;
        }
        public decimal GetTripPrice()
        {
            return Type == TripType.Passenger 
                ? (decimal)_distance * _vehicle.PassengerTransportationPrice 
                : (decimal)_distance * _vehicle.GoodsTransportationPrice;
        }

        public float GetTripDuration()
        {
            return _distance/_vehicle.AverageSpeed;
        }
    }
}
