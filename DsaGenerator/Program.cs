using System;

namespace DsaGenerator
{
    /// <summary>
    ///     Generates a DSA sequence and writes it to the console.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        ///     DSA-compliant characters.
        /// </summary>
        private static readonly string[] DsaCharacters =
        {
            "A", "S", "D", "<", ">", "?"
        };

        /// <summary>
        ///     LO7-compliant characters.
        /// </summary>
        private static readonly string[] Lo7Characters =
        {
            "L", "O", "A", "7"
        };

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

            string[] characters = null;

            if (args[0].ToUpper() == "DSA")
                characters = DsaCharacters;

            if (args[0].ToUpper() == "LO7")
                characters = Lo7Characters;

            if (characters == null)
            {
                Console.WriteLine("Invalid argument provided. Please input LO7 or DSA.");
                Environment.Exit(2);
            }

            var random = new Random();

            // accelerate heat death of the universe
            while (true)
            {
                var result = new string[random.Next(48, 64)];

                // initiate string with 'ASD'/'LOA' string bias
                result[0] = characters[0];
                result[1] = characters[1];
                result[2] = characters[2];

                // populate each index in the empty string array with a randomly chosen DSA character
                for (int i = 3; i < result.Length; i++) result[i] = characters[random.Next(0, characters.Length)];

                // write the array to the console by joining the items
                Console.WriteLine(string.Join(string.Empty, result));
            }
        }
    }
}