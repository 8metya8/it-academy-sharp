using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(1998, 22354.56, 978, 14000, 200);
            Car car = new Car(2015, 25450, 160);
            Ship ship = new Ship(2014, 345000, 56, "Cuba", 450);
            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(plane);
            vehicles.Add(car);
            vehicles.Add(ship);

            foreach(Vehicle vehicle in vehicles)
            {
                Console.WriteLine("{0}: ", vehicle.GetType().ToString().Split('.')[1]);
                Console.WriteLine("Production year - {0}, Cost - {1} $, Max speed - {2} km/h",
                               vehicle.Year, vehicle.Cost, vehicle.Speed);

                if(vehicle is Ship)
                {
                    Ship shipType = (Ship)vehicle;
                    Console.WriteLine("Port - {0}, Max count passengers - {1}",
                               shipType.Port, shipType.MaxCountOfPassengers);
                }

                if(vehicle is Plane)
                {
                    Plane planeType = (Plane)vehicle;
                    Console.WriteLine("Max flight height - {0} m, Max count passengers - {1}",
                               planeType.MaxFlightHeight, planeType.MaxCountOfPassengers);
                }

                Console.WriteLine(new string('-', 40));
            }
           
            Console.ReadKey();
        }
    }
}
