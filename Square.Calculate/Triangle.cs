using System;
namespace Square.Calculate
{
    public class Triangle : Figure
    {
        public double A, B, C;

        public Triangle()
        {
            A = B = C = 0;
        }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double Area()
        {
            var p = (A + B + C) / 2;
            double tempArea = (p * (p - A) * (p - B) * (p - C));
            // если значение меньше нуля, то меняем знак на +
            tempArea = tempArea < 0 ? -tempArea : tempArea;
            return Math.Sqrt(tempArea);
        }

        public override bool RightAngled()
        {
            var a = (int)A;
            var b = (int)B;
            var c = (int)C;
            if ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == b * b + a * a))
            { return true; } else { return false; }
        }

    }
}
