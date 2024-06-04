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
            animals.Add(new Wolfman("Sirius Black", 35, 85, true));

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine(animal.DoSound());
                if (animal is IPerson person)
                {
                    Console.WriteLine(person.Talk());
                }
            }

            List<Dog> dogs = new List<Dog>();
            // dogs.Add(new Dog("Bella", 3, 6.3, "poodle"));
            // dogs.Add(new Horse("Maria", 7, 50, 80));
            // cannot convert from Horse to Dog

            //  9. F:Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
            // För att det måste vara bara Dog-classen djur i dogs-listan.

            //  10. F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
            // Animal, för att alla classer ärver från Animal-classen.

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Stats());
            }

            // 13.F: Förklara vad det är som händer.
            // Foreach loopen går igenom alla djur i listan och skriver ut statistik genom att använda Stats-metoden.

            foreach (var animal in animals)
            {
                if (animal is Dog dog)
                {
                    Console.WriteLine(dog.Stats());
                }
            }

            // 17.F: Varför inte?
            // Jag kan inte använda DoSadSound() i animals-listan, för att Animal-classen har inte den metoden. Det är bara Dogs metod.

            foreach (var animal in animals)
            {
                if (animal is Dog dog)
                {
                    Console.WriteLine(dog.DoSadSound());
                }
            }
        }
    }
}
