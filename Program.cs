// See https://aka.ms/new-console-template for more information
namespace Oops

{
    public abstract class Animal
    {
        public string Species { get; protected set; }
        public string Name { get; set; }
        public Animal(string name, string species)
        {
            Name = name;
            Species = species;

        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal SOunds");
        }

    }

    public class Dog : Animal

    {
        public int aid;
        public Dog(string name, string species, int aid)
            : base(name, species)
        {
            //Name = name;
            //Species = "mammals";
        }
        public sealed override void MakeSound()
        {
            Console.WriteLine("Barks");


        }
    }

    public class Practice
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog("Puppy", "Mammals", 1);

            dog.MakeSound();
            Console.WriteLine(dog.Species);
            Console.WriteLine(dog.Name);
        }

    }

}