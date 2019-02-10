namespace Homework11_1
{
    class Ship : Vehicle
    {
        public string Port { get; set; }
        public int MaxCountOfPassengers { get; }

        public Ship(int year, double cost, double speed,
                     string port, int maxCountPassengers)
                     : base(year, cost, speed)
        {
            Port = port;
            MaxCountOfPassengers = maxCountPassengers;
        }
    }
}
