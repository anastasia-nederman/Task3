using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Animals
{
    public class Bird : Animal
    {
        private double wingSpan;
        public double WingSpan
        {
            get { return wingSpan; }
            set { wingSpan = value; }
        }

        public Bird(string name, int age, double weight, double wingSpan) : base(name, age, weight)
        {
            WingSpan = wingSpan;
        }

        public override string DoSound()
        {
            return "Tweet";
        }
    }
}
