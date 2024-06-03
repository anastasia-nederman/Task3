using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Animals
{
    public abstract class Animal
    {
        // Properties

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        // Constructor

        public Animal(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }


        // Methods
        public abstract string DoSound();
    }
}

// 13.F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt
// attribut, i vilken klass bör vi lägga det?
// Birds, och vi måste uppdatera constructors för alla fåglars klasser för att inkludera det nya attributet. 

// 14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
// Animal, och vi måste uppdatera constructors för alla djurs klasser för att inkludera det nya attributet.