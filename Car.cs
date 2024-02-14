using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Car : Vehicle
    {
        private int carseats;
        public int Carseats { get { return carseats; } set { carseats = value; } }

        public Car(string nameName, string colorName, int yearValue, int maxSpeedValue, string eng, int carSeatsNo):base(nameName, colorName, yearValue, maxSpeedValue,eng)
        {
            Carseats = carSeatsNo;
        }

        public Car(string nameName, string colorName, int yearValue, int maxSpeedValue) : base(nameName, colorName, yearValue, maxSpeedValue)
        {
            Carseats = 0;
        }
        
        public Car(string nameName): base(nameName)
        {
            Carseats = 0;
        }

        public void Display()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Year);
            Console.WriteLine(Color);
            Console.WriteLine(MaxSpeed);
            Console.WriteLine(engine_type);
            Console.WriteLine(Carseats);
            fullThrottle();
            Console.WriteLine();
        }
    }
}
