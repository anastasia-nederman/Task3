using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Animals
{
    public class Worm : Animal
    {
        private bool isPoisonous;
        public bool IsPoisonous
        {
            get { return isPoisonous; }
            set { isPoisonous = value; }
        }

        public Worm(string name, int age, double weight, bool isPoisonous) : base(name, age, weight)
        {
            IsPoisonous = isPoisonous;
        }

        public override string DoSound()
        {
            return "...";
        }

        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Is Poisonous: {IsPoisonous}";

        }
    }
}
