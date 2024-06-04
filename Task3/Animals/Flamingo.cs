using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Animals
{
    public class Flamingo : Bird
    {
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Flamingo(string name, int age, double weight, double wingSpan, string color) : base(name, age, weight, wingSpan)
        {
            Color = color;
        }

        public override string DoSound()
        {
            return "Honk";
        }
    }
}
