using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RocPaSci.Properties;

namespace RocPaSci
{
    internal class Paper : Throw
    {
        public override string doThrow()
        {
            return "Paper";
        }

        public override Image setImage()
        {
            return Resources.papel;
        }
    }
}
