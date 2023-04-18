using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACsApril17
{
    internal abstract class Vehicle: IDriveable // interface on the base class
    {
        public double weight;
        public double xCoord;
        public double yCoord;
        public string owner;

        public Vehicle(string owner)
        {
            this.owner = owner;
        }

        public abstract void Drive(double distance);

        public string getOwner()
        {
            return this.owner;
        }
    }
    
    internal class Car: Vehicle // Inheritance
    {
        public int doors;

        public Car(string owner) : base(owner)
        {}

        public override void Drive(double distance)
        {
            this.xCoord += distance;
            this.yCoord += 0;
        }

    }

    internal class SportsCar : Car // Inheritance
    {
        private Object Valet;

        public SportsCar(string owner) : base(owner)
        { }

    }

    internal class AbondedCar : Car 
    {
        public AbondedCar() : base("No One")
        { }

    }

    internal class Bike : Vehicle // Inheritance
    {

        public Bike(string owner) : base(owner)
        { }

        public override void Drive(double distance)
        {
            this.xCoord += distance;
            this.yCoord += 0;
        }

    }


    internal interface IDriveable
    {
        public void Drive(double distance);
    }

    internal class Driver
    {
        // assocation
        public Vehicle vehicle;

        public void Drive(double distance)
        {
            vehicle.Drive(distance);
        }
    }

}
