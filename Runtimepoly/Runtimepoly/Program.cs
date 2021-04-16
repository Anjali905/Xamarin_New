using System;

namespace Runtimepoly
{
    class Shape
    {
        public virtual void Draw() { }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle drawn");
        }
    }
    class Triangle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Triangle drawn");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shape = new Shape[2];
            shape[0] = new Rectangle();
            shape[1] = new Triangle();
            for(int i =0; i <= 1;i++)
            {
                shape[i].Draw();

            }

        }
    }
}
