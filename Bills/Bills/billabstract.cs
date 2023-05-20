using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    internal abstract class billabstract
    {
        protected const double INTEREST = .10;
        public abstract double billcompute();
    }
}
