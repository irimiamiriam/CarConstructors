using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Vehicle
    {   public string engine_type = "gas";
        protected string color;
        protected string name;
        protected int year;
        protected int maxSpeed;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Year
        {

            get { return year; }
            set
            {
                if (value > 1980 && value <= 2024) { year = value; }
                else { throw new Exception("Please pass a correct value for " + Name); }
            }
        }
        
        public int MaxSpeed
        {
            get { return maxSpeed; }
            set
            {
                maxSpeed = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
            
        }

        public Vehicle(string nameC, string colorC, int yearC, int maxC, string eng)
        {
            name = nameC;
            color = colorC;
            Year = yearC;
            maxSpeed = maxC;
            engine_type = eng;

        }
        public Vehicle(string nameC, string colorC, int yearC, int maxC)
        {
            name = nameC;
            color = colorC;
            year = yearC;
            maxSpeed = maxC;
            

        }

        public Vehicle (string nameC)
        {
            name = nameC;
        }

        /*public void Display()
        {
            Console.WriteLine(name);
            Console.WriteLine(year);
            Console.WriteLine(color);
            Console.WriteLine(maxSpeed);
            Console.WriteLine(engine_type);
            fullThrottle();
            Console.WriteLine();
        }*/
        public void fullThrottle()
        {
            Console.WriteLine(name + " is going at the speed of " + maxSpeed);
        }

        public void honk()
        {
            Console.WriteLine("Tuuut! tuuut!");
        }

    }
}
