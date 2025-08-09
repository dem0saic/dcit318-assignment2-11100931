namespace ShapesAreaCalculator
{
    /// <summary>
    /// Abstract base for geometric shapes. Forces implementers to provide
    /// their own area calculation via <see cref="GetArea"/>.
    /// </summary>
    public abstract class Shape
    {
        /// <summary>Compute the area for the particular shape.</summary>
        public abstract double GetArea();
    }

    /// <summary>
    /// Circle shape implementation with immutable radius.
    /// </summary>
    public class Circle : Shape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        /// <summary>Area formula: πr².</summary>
        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }

    /// <summary>
    /// Rectangle shape implementation with immutable width and height.
    /// </summary>
    public class Rectangle : Shape
    {
        private readonly double _width;
        private readonly double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        /// <summary>Area formula: width × height.</summary>
        public override double GetArea()
        {
            return _width * _height;
        }
    }

    internal class Program
    {
        /// <summary>
        /// Entry point: instantiate a circle and rectangle and print their areas
        /// using the shared <see cref="Shape"/> abstraction.
        /// </summary>
        private static void Main()
        {
            var circle = new Circle(5); // radius = 5
            var rectangle = new Rectangle(4, 6); // width = 4, height = 6

            Console.WriteLine($"Circle area: {circle.GetArea():F2}");
            Console.WriteLine($"Rectangle area: {rectangle.GetArea():F2}");
        }
    }
}
