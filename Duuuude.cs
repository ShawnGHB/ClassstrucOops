using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_structOop
{
    internal class Duuuude
    {
        public string name;
        public int xp = 0;


        public Duuuude(string name)
        {
            this.name = name;
            //Reset();
        }
        public Duuuude()
        {
            name = "Not assigned";
        }
        public virtual void PrintStatsInfo()
        {
            Console.WriteLine("Hero: " + this.name + " - " + this.xp + " EXP");
        }
        private void Reset()
        {
            this.name = "Not assigned";
            this.xp = 0;
        }
    }
}
