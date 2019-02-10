namespace Homework11_1
{
    class Vehicle
    {
        public int Year { get; }
        public double Cost { get; set; }
        public double Speed { get; }

        public Vehicle(int year, double cost, double speed)
        {
            Year = year;
            Cost = cost;
            Speed = speed;
        }
    }
}
