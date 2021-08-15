using MindboxSolution.Library.Exceptions;
using MindboxSolution.Library.Interfaces;
using System;
using System.Linq;

namespace MindboxSolution.Library.Shapes
{
    public class Triangle : ISquare
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;

        public Triangle(double a, double b, double c) 
        {
            CheckSedies(a,b,c);
            (this.a, this.b, this.c) = (a, b, c);
        } 

        public double GetSquare()
        {
            var halfPerimeter = (a + b + c) / 2.0;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
        }

        public bool IsRight() 
        {
            var sideArr = new double[] {a,b,c};
            var maxSide = sideArr.Max();

            return a == maxSide ? PifagoreRule(a, b, c) :
                b == maxSide ? PifagoreRule(b, a, c) :
                c == maxSide && PifagoreRule(c, b, a) ;
        }

        private bool PifagoreRule( double hypotenuse, double catet1, double catet2) 
        {
            return Math.Pow(hypotenuse, 2) == Math.Pow(catet1, 2) + Math.Pow(catet2, 2);
        }

        private void CheckSedies(double a, double b, double c) 
        {
            if (a <= 0 || b <= 0 || c <= 0) 
            {
                throw new TriangleSediesLessZeroException("Стороны не должны быть меньше либо равны 0");
            }

            if (a >= (b + c) || b >= (a + c) || c >= (b + a)) 
            {
                throw new TriangleNotExistsException("Триугольника не существует");
            }
        }
    }
}
