using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
*
*
Write a program that calculates the distance of 2 points from the origin, as well as from each other. The distance between 2 points can be calculated using the formula:
//https://www.mathsisfun.com/algebra/distance-2-points.html
//https://www.youtube.com/watch?v=CWUr6Jo6tag

Read the coordinates of 2 2D points from the user. A point is represented by its x, y coordinates.
Calculate and print the distance of the first point from the origin, (0, 0).
Calculate and print the distance of the second point from the origin.
Calculate and print the distance between the two points.
*/


class Program
 {
            public static void Main(string[] args)
            {
                //read in 2 points from the user by having them input 4 values
                double x1, x2, y1, y2;//have code to read these all in
                Console.WriteLine("Enter x1 ");
                x1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter x2 ");
                x2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter y1 ");
                y1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter y2 ");
                y2 = double.Parse(Console.ReadLine());

                Console.WriteLine("The distance between x1, y1 and the origin is " + CalculateDistanceFromTwoPoints(x1, 0, y1, 0));
                Console.WriteLine("The distance between x2, y2 and the origin is " + CalculateDistanceFromTwoPoints(x2, 0, y2, 0));
                Console.WriteLine("The distance between x1, x2 and y1, y2 is " + CalculateDistanceFromTwoPoints(x1, x2, y1, y2));
               
                Console.Read();
            }
    //make a function here to calculate the distance from two points
    static double CalculateDistanceFromTwoPoints(double x1, double x2, double y1, double y2)
    {
        double distance = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2));
        return distance;
        // the above could also be written as: return Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2));
    }




}
