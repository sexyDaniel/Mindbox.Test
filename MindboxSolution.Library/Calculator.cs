using MindboxSolution.Library.Interfaces;
using System;

namespace MindboxSolution.Library
{
    public static class Calculator
    {
        public static double GetSquare(ISquare square) 
        {
            return square.GetSquare();
        } 
    }
}
