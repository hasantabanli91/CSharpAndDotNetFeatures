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

    public abstract class Cars : IWheeleCount // Abstract class defines features what a class have to do.
    {
        public abstract string Color { get; set; }
        public abstract string Model { get; set; }
        public void Drive()
        {
            Console.WriteLine("Driving");
        }
        public abstract void GetWheeleCount();
    }

    public interface IWheeleCount // Interfaces defines features what a class need.
    {
        void GetWheeleCount();
    }

    public interface ILuxFeatures
    {
        void SeatHeating();
    }
}
