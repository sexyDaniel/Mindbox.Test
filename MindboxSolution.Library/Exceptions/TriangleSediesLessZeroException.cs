using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxSolution.Library.Exceptions
{
    public class TriangleSediesLessZeroException:Exception
    {
        public TriangleSediesLessZeroException(string message) : base(message) { }
    }
}
