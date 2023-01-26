using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures
{
    public class Mercedes : Cars, ILuxFeatures
    {
        public override string Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void GetWheeleCount()
        {
            Console.WriteLine("4");
        }

        public void SeatHeating()
        {
            Console.WriteLine("Seats can be heat");
        }
    }

    public abstract class Cars : IWheeleCount           // Abstract class defines features what a class can need.
    {                                                   // A class can extend only one abstract class
        public abstract string Color { get; set; }      // Abstract properties and Normal properties can be define in Abstract classes 
        public abstract string Model { get; set; }      // Abstract classes can implements other abstract classes and interfaces too.
        public void Drive()                             // Abstract classes can take access modifiers.
        {
            Console.WriteLine("Driving");               
        }                                               
        public abstract void GetWheeleCount();
    }

    public interface IWheeleCount                        // Interfaces defines features what a class have to have.
    {                                                    // Interfaces supports multiple inheritence
        void GetWheeleCount();                           // Everythings in interfaces are public
    }

    public interface ILuxFeatures
    {
        void SeatHeating();
    }
}
