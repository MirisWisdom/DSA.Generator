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
        ///     String value for the DSA argument.
        /// </summary>
        private const string DsaArg = "DSA";

        /// <summary>
        ///     String value for the LO7 argument.
        /// </summary>
        private const string Lo7Arg = "LO7";

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

            switch (args[0].ToUpper())
            {
                case DsaArg:
                    generator = GeneratorFactory.Get(GeneratorFactory.Type.Dsa);
                    break;
                case Lo7Arg:
                    generator = GeneratorFactory.Get(GeneratorFactory.Type.Lo7);
                    break;
                default:
                    Console.WriteLine("Invalid argument provided. Please input LO7 or DSA.");
                    Environment.Exit(2);
                    break;
            }

            // accelerate heat death of the universe
            while (true)
                Console.WriteLine(generator.Get());
        }
    }
}