namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FeaturesStudent student = new FeaturesStudent("ggg fff ddd", 12, 667788);
            Console.WriteLine(student.Info());

            Cat cat = new Cat("Ибрагим", "безпородный", "12.07.1999", 3);
            Console.WriteLine(cat.Info());
        }
    }
}
