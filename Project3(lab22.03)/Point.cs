using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_lab22._03_
{
    public class Point
    {
        #region Properties
        public double X { get; set; }
        public double Y { get; set; }

        //public Color Color { get; set; }
        #endregion
        #region Contructors
        public Point() : this (0, 0)
        {

        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
            Console.WriteLine($"Am creat un obiect de timp Point ({X}, {Y})");
        }

        public Point(int x) : this(x, 0) //constructor telescopic
        {

        }
        #endregion
        #region Override
        public override string ToString()
        {
            return $"({X},{Y})";
        }
        #endregion
        #region Methods
        public double GetDistanceToOrigin()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        public double GetDistanceTo(Point to)
        {
            return Math.Sqrt(Math.Pow(this.X - to.X, 2)+ 
                                Math.Pow(this.Y - to.Y, 2));
        }
        public void MoveBy(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }
        //360 grade = 2 pii radiani 
        //rotire din x1 y1 in x2 y2 cu alfa grade
        //x2 = xcosalfa -ysinalfa
        //y2 = xsinalfa +ycosalfa
        public void Rotire(double angle)
        {

        }
        #endregion
    }
}
