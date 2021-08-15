using System;
using MindboxSolution.Library.Interfaces;
using MindboxSolution.Library.Exceptions;

namespace MindboxSolution.Library.Shapes
{
    public class Circle : ISquare
    {
        private readonly double radius;

        public Circle(double radius) 
        {
            CheckRadius(radius);
            this.radius = radius;
        } 
        public double GetSquare()
        {
            return Math.PI * radius * radius;
        }

        private void CheckRadius(double r)
        {
            if (r<=0)
            {
                throw new CircleRadiusLessZeroException("Радиус должен быть больше 0");
            }
        }
    }
}
