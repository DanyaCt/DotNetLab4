namespace DotNetLab4.Trips
{
    public interface ITrip
    {
        public TripType Type { get; }
        public decimal GetTripPrice();
        public float GetTripDuration();
    }
}
