using Pr_3.Modules;

namespace Pr_3
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask();
            //SecondTask();
        }

        static void FirstTask()
        {
            Book myBook = new Book("Awesome Book", "Very Cool Author", "Book with the coolest content!");

            myBook.ShowInfo();
        }

        static void SecondTask()
        {
            Console.WriteLine("Enter coordinates for point A (x, y):");
            string[] input1 = Console.ReadLine().Split(',');
            int x1 = int.Parse(input1[0].Trim());
            int y1 = int.Parse(input1[1].Trim());
            Point point1 = new Point(x1, y1, "A");

            Console.WriteLine("Enter coordinates for point B (x, y):");
            string[] input2 = Console.ReadLine().Split(',');
            int x2 = int.Parse(input2[0].Trim());
            int y2 = int.Parse(input2[1].Trim());
            Point point2 = new Point(x2, y2, "B");

            Console.WriteLine("Enter coordinates for point C (x, y):");
            string[] input3 = Console.ReadLine().Split(',');
            int x3 = int.Parse(input3[0].Trim());
            int y3 = int.Parse(input3[1].Trim());
            Point point3 = new Point(x3, y3, "C");

            Figure myFigure = new Figure(point1, point2, point3);

            myFigure.PerimeterCalculator();
        }
    }
}
