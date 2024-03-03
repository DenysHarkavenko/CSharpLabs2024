using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        //FirstTask();
        //SecondTask();
        //ThirdTask();
        FourthTask();
    }

    static void FirstTask()
    {
        int[] numbers = new int[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter a number {i + 1}: ");
            int input = int.Parse(Console.ReadLine());
            numbers[i] = input;
        }

        Console.Write("\nNumbers in the array that are in the range from 1 to 38: ");

        foreach (int number in numbers)
        {
            if (number >= 1 && number <= 15)
            {
                Console.Write(number + " ");
            }
        }

        Console.ReadLine();
    }

    static void SecondTask()
    {
        int side1, side2, side3;

        Console.WriteLine("Enter the lengths of the triangle sides:");
        Console.Write("Side 1: ");
        while (!int.TryParse(Console.ReadLine(), out side1) || side1 <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number:");
            Console.Write("Side 1: ");
        }
        Console.Write("Side 2: ");
        while (!int.TryParse(Console.ReadLine(), out side2) || side2 <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number:");
            Console.Write("Side 2: ");
        }
        Console.Write("Side 3: ");
        while (!int.TryParse(Console.ReadLine(), out side3) || side3 <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number:");
            Console.Write("Side 3: ");
        }

        double perimeter = side1 + side2 + side3;
        Console.WriteLine($"Perimeter of the triangle: {perimeter}");

        if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
        {
            double s = perimeter / 2;
            double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));

            Console.WriteLine($"Area of the triangle: {area}");

            if (side1 == side2 && side2 == side3)
                Console.WriteLine("The triangle is equilateral.");
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                Console.WriteLine("The triangle is isosceles.");
            else
                Console.WriteLine("The triangle is scalene.");
        }
        else
        {
            Console.WriteLine("Such triangle does not exist.");
        }

        Console.ReadLine();
    }

    static void ThirdTask()
    {
        int[] X = new int[15];

        Random random = new Random();
        for (int i = 0; i < X.Length; i++)
        {
            X[i] = random.Next(100);
        }

        int min = X[0];
        int max = X[0];
        for (int i = 1; i < X.Length; i++)
        {
            if (X[i] < min)
                min = X[i];
            if (X[i] > max)
                max = X[i];
        }

        Console.Write("Array X: ");
        foreach (int num in X)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\nMin value: " + min);
        Console.WriteLine("Max value: " + max);

        Console.ReadLine();
    }

    static void FourthTask()
    {
        int[] X = new int[15];
        int[] Y;
        int M;

        Random random = new Random();
        for (int i = 0; i < X.Length; i++)
        {
            X[i] = random.Next(-10, 11); 
        }

        Console.WriteLine("Enter the value of M: ");
        while (!int.TryParse(Console.ReadLine(), out M))
        {
            Console.WriteLine("Invalid input. Please enter an integer value:");
        }

        Y = new int[CountElementsAboveM(X, M)];
        int index = 0;
        foreach (int element in X)
        {
            if (Math.Abs(element) > M)
            {
                Y[index] = element;
                index++;
            }
        }

        Console.WriteLine("M: " + M);
        Console.WriteLine("Array X:");
        PrintArray(X);
        Console.WriteLine("Array Y:");
        PrintArray(Y);

        Console.ReadLine();
    }

    static int CountElementsAboveM(int[] array, int M)
    {
        int count = 0;
        foreach (int element in array)
        {
            if (Math.Abs(element) > M)
            {
                count++;
            }
        }
        return count;
    }

    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
