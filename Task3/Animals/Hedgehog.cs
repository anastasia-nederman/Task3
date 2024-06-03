using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Animals
{
    public class Hedgehog : Animal
    {
        private int nrOfSpikes;
        public int NrOfSpikes
        {
            get { return nrOfSpikes; }
            set { nrOfSpikes = value; }
        }

        public Hedgehog(string name, int age, double weight, int nrOfSpikes) : base(name, age, weight)
        {
            NrOfSpikes = nrOfSpikes;
        }

        public override string DoSound()
        {
            return "Huff";
        }
    }
}
