using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Person
    {
        private int age; 
         
        public int Age 
        {
            get { return age; }
            set
            {
                if (value <= 0) { throw new ArgumentException("Age should be more than 0"); }
                else { age = value; }
            }
        }
        private string fName;
        public string FName
        {
            get { return fName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("First name is mandatory");
                if (2 <= value.Length && value.Length <= 10) 
                    fName = value; 
                else 
                    throw new ArgumentException("First name should have between 2 and 10 characters"); 
            }
        }
        private string lName;
        public string LName
        {
            get { return lName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Last name is mandatory");
                if (3 <= value.Length && value.Length <= 15)
                    lName = value; 
                else 
                    throw new ArgumentException("Last name should have between 3 and 15 characters"); 
            }
        }
        private double height;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

    }
}
