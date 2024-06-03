using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Animals
{
    public class Pelican : Bird
    {
        private double neckLength;
        public double NeckLength
        {
            get { return neckLength; }
            set { neckLength = value; }
        }

        public Pelican(string name, int age, double weight, double wingSpan, double neckLength) : base(name, age, weight, wingSpan)
        {
            NeckLength = neckLength;
        }

        public override string DoSound()
        {
            return "Grunt";
        }
    }
}
