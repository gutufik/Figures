using System;

namespace GeometryFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Point
    {
        int x;
        int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Line
    {
        Point startPoint;
        Point endPoint;

        public Line(Point firstPoint, Point secondPoint)
        {
            startPoint = firstPoint;
            endPoint = secondPoint;
        }
    }

    class Figure
    {
        int topsCount;
        Point[] tops;
        Line[] sides;

        public Figure(int pointCount, Point[] points)
        {
            topsCount = pointCount;
            tops = points;
        }
    }
    class Rectangle : Figure
    {
        public Rectangle(Point[] points) : base(4, points)
        {

        }
    }
    class Square : Rectangle
    {
        public Square(Point[] points) : base(points)
        { }
    }
    class Triangle : Figure
    {
        public Triangle(Point[] points) : base(3, points)
        { }
    }
}
