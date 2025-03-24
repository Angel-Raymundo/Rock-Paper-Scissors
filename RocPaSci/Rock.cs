using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RocPaSci.Properties;

namespace RocPaSci
{
    internal class Rock : Throw
    {
        public override string doThrow()
        {
            return "Rock";
        }

        public override Image setImage()
        {
            return Resources.piedra;
        }
    }
}
