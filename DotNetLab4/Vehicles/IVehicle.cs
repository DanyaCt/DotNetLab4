namespace DotNetLab4.Vehicles
{
    public interface IVehicle
    {
        public float AverageSpeed { get; }
        public decimal PassengerTransportationPrice { get; }
        public decimal GoodsTransportationPrice { get; }
    }
}
