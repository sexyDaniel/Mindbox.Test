using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxSolution.Library.Exceptions
{
    public class TriangleNotExistsException : Exception
    {
        public TriangleNotExistsException(string message) : base(message) { }
    }
}
