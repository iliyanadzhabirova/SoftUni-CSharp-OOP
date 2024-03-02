
namespace _01.ClassBoxData
{
    public class Box
    {
		private readonly double length;
        private readonly double width;
        private readonly double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Height
        {
            get => height;
            init {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Height)} cannot be zero or negative. ");
                }
                height = value; 
            }
        }

        public double Width
        {
            get => width;
            init {

                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Width)} cannot be zero or negative. ");
                }

                width = value; 
                }
        }

        public double Length
        {
            get => length;
           init {
                if (value<=0)
                {
                    throw new ArgumentException($"{nameof(Length)} cannot be zero or negative. ");
                }
                length = value; }
        }
        public double Volume()
        {
            return Width * Height * Length;
        }
        public double LateralSurfaceArea()
        {
            return 2 * Length * Height + 2 * Width * Height;
        }
        public double SurfaceArea()
        {
            return 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;
        }
    }
}
