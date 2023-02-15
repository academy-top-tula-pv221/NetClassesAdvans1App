using System.Xml.Linq;

namespace NetClassesAdvans1App
{
    class Currency
    {
        public readonly decimal course = 67.5m;

        public Currency()
        {

        }
        public Currency(decimal course)
        {
            this.course = course;
        }
    }
    class Circle
    {
        public const double Pi = 3.1416;
        public double Radius { set; get; }
    }
    class User
    {
        public static int Id;
        public string Name { set; get; }
        public int Age { set; get; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        static User()
        {
            Id = 100;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} {Age} {Id}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new("Joe", 23);
            user.Name = "Bob";
            User.Id = 500;
            user.PrintInfo();

            User user2 = new("Bob", 34);
            user2.PrintInfo();

            DateTime day = new();
            Console.WriteLine(DateTime.Now.ToString());

            Circle circle = new() { Radius = 5 };
            double x = Circle.Pi;
        }

        // overloading methods
        /*
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Sum(ref int a, ref int b)
        {
            return a + b;
        }
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        float Sum(float a, float b)
        {
            return a + b;
        }
        int Sum(float a, int b)
        {
            return (int)a + b;
        }
        int Sum(int a, float b)
        {
            return a + (int)b;
        }
        */
    }
}