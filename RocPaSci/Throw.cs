using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RocPaSci.Properties;

namespace RocPaSci
{
    internal class Throw
    {
        public virtual string doThrow()
        {
            return "Default throw";

        }

        public virtual Image setImage()
        {
            return Resources.none;
        }
    }
}
