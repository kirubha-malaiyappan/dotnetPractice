
namespace assesment
{


    //Interface
    interface IWorker
    {
        void Work();
    }

    //Abstract class
    abstract class Person
    {
        // Field
        protected int age;

        // Property (Encapsulation)
        public string Name { get; set; }

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            this.age = age;
        }

        // Abstract method 
        public abstract void Introduce();

        // Concrete method
        public void ShowAge()
        {
            Console.WriteLine($"Age: {age}");
        }
    }

    //Inheritance
    class Employee : Person, IWorker
    {
        // Property
        public double Salary { get; private set; }

        // Constructor
        public Employee(string name, int age, double salary)
            : base(name, age)
        {
            Salary = salary;
        }

        // Polymorphism (method override)
        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name} and I am an employee.");
        }

        // Interface method implementation
        public void Work()
        {
            Console.WriteLine("Employee is working in backend");
        }

        // Method
        public void GiveRaise(double amount)
        {
            Salary += amount;
        }
    }


    class Program
    {
        static void Main()
        {
            //Data Types and Variables
            int number = 10;
            double price = 99.99;
            bool isActive = true;
            string message = "hi";

            //Operators
            int sum = number + 5;
            bool isGreater = sum > 10;

            //Conditional Statement
            if (isGreater)
            {
                Console.WriteLine("greater than 10");
            }
            else
            {
                Console.WriteLine("less than 10");
            }

            //Loop
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(i);
            }


            //Object
            Employee emp = new Employee("Kiru", 21, 50000);

            //Method calling
            emp.Introduce();
            

            emp.GiveRaise(5000);
            Console.WriteLine($"New Salary: {emp.Salary}");

            //Polymorphism
            Person personRef = emp;
            personRef.Introduce();

            //Exception Handling
            int x = 5;
            int y = 0;

            try
            {
                int result = x / y;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
            }

            Console.WriteLine("Program finished successfully.");
        }
    }
}
