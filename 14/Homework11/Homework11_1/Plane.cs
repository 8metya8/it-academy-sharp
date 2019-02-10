namespace Homework11_1
{
    class Plane : Vehicle
    {
        public double MaxFlightHeight { get; }
        public int MaxCountOfPassengers { get; }

        public Plane(int year, double cost, double speed,
                     double maxFlightHeight, int maxCountPassengers)
                     :base(year, cost, speed)
        {
            MaxFlightHeight = maxFlightHeight;
            MaxCountOfPassengers = maxCountPassengers;
        }
    }
}
