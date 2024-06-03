using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Animals
{
    public class Horse : Animal
    {
        private double maxSpeed;
        public double MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value; }
        }

        public Horse(string name, int age, double weight, double maxSpeed) : base(name, age, weight)
        {
            MaxSpeed = maxSpeed;
        }

        public override string DoSound()
        {
            return "Neigh";
        }
    }
}
