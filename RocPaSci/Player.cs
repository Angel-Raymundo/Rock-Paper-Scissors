using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using RocPaSci.Properties;

namespace RocPaSci
{
    internal class Player
    {
        private string name;
        private Throw play;

        public string Name { get => name; set => name = value; }
        public Throw Play { get => play; set => play = value; }

        public virtual void doPlay(Throw play)
        {
            this.Play = play;
            play.doThrow();
            
        }
    }
}
