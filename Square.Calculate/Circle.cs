using System;
namespace Square.Calculate
{
    public class Circle : Figure
    {
        public int R;

        public Circle()
        {
            R = 0;
        }

        public Circle(int rad)
        {
            R = rad;
        }

        public override double Area()
        {
            return Math.PI * R * R;
        }
        public override bool RightAngled()
        {
            return false;
        }
    }
}
