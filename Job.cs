using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11
{
    // a job consists of a name and a description
    internal abstract class Job
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public abstract void Report(); // must be implemented in subclasses
    }
}
