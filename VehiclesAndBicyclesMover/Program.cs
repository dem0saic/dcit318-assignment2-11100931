namespace VehiclesAndBicyclesMover
{
    /// <summary>
    /// Contract that describes the ability to move. Any type that can move
    /// simply needs to provide a <see cref="Move"/> implementation.
    /// </summary>
    public interface IMovable
    {
        void Move();
    }

    /// <summary>
    /// Car implements <see cref="IMovable"/> and prints a message when moving.
    /// </summary>
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    /// <summary>
    /// Bicycle implements <see cref="IMovable"/> and prints a message when moving.
    /// </summary>
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    internal class Program
    {
        /// <summary>
        /// Entry point: create instances of <see cref="Car"/> and <see cref="Bicycle"/>
        /// through the <see cref="IMovable"/> interface and invoke <see cref="IMovable.Move"/>.
        /// Demonstrates programming to an interface.
        /// </summary>
        private static void Main()
        {
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            car.Move();
            bicycle.Move();
        }
    }
}
