using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Animals
{
    public class Swan : Bird
    {
        private bool isWild;
        public bool IsWild
        {
            get { return isWild; }
            set { isWild = value; }
        }

        public Swan(string name, int age, double weight, double wingSpan, bool isWild) : base(name, age, weight, wingSpan)
        {
            IsWild = isWild;
        }

        public override string DoSound()
        {
            return "Snort";
        }
    }
}
