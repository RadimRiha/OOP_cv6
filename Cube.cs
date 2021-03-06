using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv6
{
    public class Cube : Object3D
    {
        public double Width { get; private set; }
        public double Height { get; private set; }
        public double Depth { get; private set; }
        public Cube(double width, double height, double depth)
        {
            if (width < 0 || height < 0 || depth < 0) throw new Exception("Cannot create object with negative dimensions");
            Width = width;
            Height = height;
            Depth = depth;
        }
        public override void Draw()
        {
            Console.WriteLine("Cube ({0} x {1} x {2})", Width, Height, Depth);
        }
        public override double CalculateSurfaceArea()
        {
            return 2 * (Width * Height + Height * Depth + Depth * Width);
        }
        public override double CalculateVolume()
        {
            return Width * Height * Depth;
        }
    }
}
