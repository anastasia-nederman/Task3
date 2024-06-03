using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Animals
{
    public class Wolf : Animal
    {
        private bool isLonely;
        public bool IsLonely
        {
            get { return isLonely; }
            set { isLonely = value; }
        }

        public Wolf(string name, int age, double weight, bool isLonely) : base(name, age, weight)
        {
            IsLonely = isLonely;
        }

        public override string DoSound()
        {
            return "Howl";
        }

        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Is Lonely: {IsLonely}";

        }
    }
}
