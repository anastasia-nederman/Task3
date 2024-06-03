using System.Reflection;
using Task3.Animals;
using Task3.Errors;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3.1

            /* 
            var anna = new Person();
            try
            {
                anna.FName = "Anna";
            }
            catch (ArgumentException arg)
            {
                Console.WriteLine(arg.Message);
            }
            try
            {
                anna.Age = 20;
            }
            catch (ArgumentException arg)
            {
                Console.WriteLine(arg.Message);
            }
            */

            var handler = new PersonHandler();

            try
            {
                var anna = handler.CreatePerson(25, "Anna", "Smith", 171, 60);
                Console.WriteLine($"Created person: {anna.FName} {anna.LName}, Age: {anna.Age}, Height: {anna.Height}, Weight: {anna.Weight}");
                try
                {
                    handler.SetAge(anna, 26);
                    Console.WriteLine($"Anna's age is set to {anna.Age}");
                }
                catch (ArgumentException arg)
                {
                    Console.WriteLine(arg.Message);
                }
            }
            catch (ArgumentException arg)
            {
                Console.WriteLine(arg.Message);
            }

            // 3.2

            List<UserError> userErrors = new List<UserError>();
            userErrors.Add(new NumericInputError());
            userErrors.Add(new TextInputError());
            userErrors.Add(new EmptyInputError());
            userErrors.Add(new RangeInputError());
            userErrors.Add(new FormatInputError());

            foreach (var error in userErrors)
            {
                Console.WriteLine(error.UEMessage());
            }

            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog("Jack", 9, 13.3, "golden retriever"));
            animals.Add(new Hedgehog("Charlie", 2, 0.7, 3300));
            animals.Add(new Worm("Severus", 1, 0.8, true));
            animals.Add(new Wolfman("Regulus Black", 35, 85, true));

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Stats());
                Console.WriteLine(animal.DoSound());
                if (animal is IPerson person)
                {
                    Console.WriteLine(person.Talk());
                }
            }




        }
    }
}
