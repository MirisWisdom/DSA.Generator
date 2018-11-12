using System;
using DsaGenerator.Generators;

namespace DsaGenerator
{
    /// <summary>
    ///     Generates a DSA/LO7 sequence and writes it to the console.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        ///     Main loop.
        /// </summary>
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No argument provided. Please input LO7 or DSA.");
                Environment.Exit(1);
            }

            Generator generator = null;

            if (args[0].ToUpper() == "DSA")
                generator = GeneratorFactory.Get(GeneratorFactory.Type.Dsa);

            if (args[0].ToUpper() == "LO7")
                generator = GeneratorFactory.Get(GeneratorFactory.Type.Lo7);

            if (generator == null)
            {
                Console.WriteLine("Invalid argument provided. Please input LO7 or DSA.");
                Environment.Exit(2);
            }

            // accelerate heat death of the universe
            while (true)
                Console.WriteLine(generator.Get());
        }
    }
}