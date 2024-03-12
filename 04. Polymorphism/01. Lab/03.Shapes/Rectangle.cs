
using System.Text;

namespace Shapes
{
   
        public class Rectangle : Shape
        {
            public double Height { get; private set; }

            public double Width { get; private set; }

            public Rectangle(double height, double width)
            {
                this.Height = height;
                this.Width = width;
            }

            public override double CalculateArea()
            {
                return this.Height * this.Width;
            }

            public override double CalculatePerimeter()
            {
                return (this.Width + this.Height) * 2;
            }

            public override string Draw()
            {
                return base.Draw() + GetType().Name;
            }

            
        }
    }


