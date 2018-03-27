using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.Draw();
            Point p2 = new Point(2,4,'#');
            p2.Draw();
            Point p3 = new Point(8, 10, '*');
            p3.Draw();
            Point p4 = new Point(11, 13, '*');
            p4.Draw();

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            upLine.Drow();
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            downLine.Drow();

            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            leftLine.Drow();
            VerticalLine reightLine = new VerticalLine(0, 24, 78, '+');
            reightLine.Drow();

            Console.ReadLine();
        }
    }
}
