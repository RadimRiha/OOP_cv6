using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv6
{
    public class Pyramid : Object3D
    {
        public double NumberOfSides { get; private set; }
        public double SideLength { get; private set; }
        public double Height { get; private set; }
        public Pyramid(int numberOfSides, double sideLength, double height)
        {
            if (sideLength < 0 || height < 0) throw new Exception("Cannot create object with negative dimensions");
            if (numberOfSides < 3) throw new Exception("Cannot construct pyramid with less than 3 sides");
            NumberOfSides = numberOfSides;
            SideLength = sideLength;
            Height = height;
        }
        public override void Draw()
        {
            Console.WriteLine("Pyramid (sides: {0}, side length = {1}, height = {2})", NumberOfSides, SideLength, Height);
        }
        private double baseTriangleHeight()
        {
            return (SideLength / 2) / Math.Tan(2 * Math.PI / NumberOfSides / 2);
        }
        private double baseArea()
        {
            return NumberOfSides * 1 / 2 * SideLength * baseTriangleHeight();
        }
        public override double CalculateSurfaceArea()
        {
            double sideTriangleHeight = Math.Sqrt(Height * Height + baseTriangleHeight() * baseTriangleHeight());
            return baseArea() + NumberOfSides * 1 / 2 * sideTriangleHeight * SideLength;
        }
        public override double CalculateVolume()
        {
            return 1.0 / 3 * baseArea() * Height;
        }
    }
}
