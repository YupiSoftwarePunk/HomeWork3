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

            Console.WriteLine("\n");

            Tower tower = new Tower(100, "Tower", 12.5, 20);
            Console.WriteLine(tower.GetRevenue(10));
            Console.WriteLine(tower.Info());
        }
    }
}
