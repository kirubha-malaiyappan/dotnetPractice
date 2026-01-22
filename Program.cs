// See https://aka.ms/new-console-template for more information
namespace Oops

{
    public abstract class Animal
    {
        public string Species { get; protected set; }
        public string Name { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal SOunds");
        }

    }

    public class Dog : Animal

    {
        public Dog(string name)
        {
            Name = name;
            Species = "mammals";
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
            Animal dog = new Dog("Puppy");

            dog.MakeSound();
            Console.WriteLine(dog.Species);
            Console.WriteLine(dog.Name);
        }

    }

}