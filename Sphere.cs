using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cv6
{
    public class Sphere : Object3D
    {
        public double Radius { get; private set; }
        public Sphere(double radius)
        {
            Radius = radius;
        }
        public override void Draw()
        {
            Console.WriteLine("Sphere (r = {0})", Radius);
        }
        public override double CalculateSurfaceArea()
        {
            return 4 * Math.PI * Radius * Radius;
        }
        public override double CalculateVolume()
        {
            return 4 / 3 * Math.PI * Radius * Radius * Radius;
        }
    }
}
