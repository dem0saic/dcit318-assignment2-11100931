namespace AnimalSoundApp
{
    /// <summary>
    /// Base type representing an animal with a virtual <see cref="MakeSound"/> behavior
    /// that derived classes can override to provide specific sounds.
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// Emits a default, generic sound. Marked virtual so subclasses can override.
        /// </summary>
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    /// <summary>
    /// Concrete animal that overrides <see cref="MakeSound"/> to bark.
    /// </summary>
    public class Dog : Animal
    {
        /// <inheritdoc />
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    /// <summary>
    /// Concrete animal that overrides <see cref="MakeSound"/> to meow.
    /// </summary>
    public class Cat : Animal
    {
        /// <inheritdoc />
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    internal class Program
    {
        /// <summary>
        /// Entry point: creates one instance of each animal and invokes their sounds
        /// to demonstrate runtime polymorphism via method overriding.
        /// </summary>
        private static void Main()
        {
            var genericAnimal = new Animal();
            var dog = new Dog();
            var cat = new Cat();

            genericAnimal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();
        }
    }
}
