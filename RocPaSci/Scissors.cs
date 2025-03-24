using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using RocPaSci.Properties;

namespace RocPaSci
{
    internal class Scissors : Throw
    {
        public override string doThrow()
        {
            return "Scissors";
        }

        public override Image setImage()
        {
            return Resources.tijeras;
        }
    }
}
