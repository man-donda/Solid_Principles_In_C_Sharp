using System;

namespace Test.src.Solid.I
{
    public class Circle : IShape2D
    {
        public double Radius { get; set; }

        public double Area() => Math.PI * Radius * Radius;
    }  
}