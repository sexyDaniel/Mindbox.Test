using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxSolution.Library.Exceptions
{
    public class CircleRadiusLessZeroException:Exception
    {
        public CircleRadiusLessZeroException(string message) : base(message) { }
    }
}
