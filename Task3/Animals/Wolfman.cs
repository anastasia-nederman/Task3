using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Animals
{
    public class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, int age, double weight, bool isLonely) : base(name, age, weight, isLonely)
        {
        }

        public string Talk()
        {
            return "Hello world, do not be afraid of me";
        }
    }
}
