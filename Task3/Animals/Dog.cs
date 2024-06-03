using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Animals
{
    public class Dog : Animal
    {
        private string breed;
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public Dog(string name, int age, double weight, string breed) : base(name, age, weight)
        {
            Breed = breed;
        }

        public override string DoSound()
        {
            return "Bark";
        }

        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Breed: {Breed}";

        }
    }
}

