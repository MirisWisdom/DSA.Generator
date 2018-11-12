﻿using System;

namespace DSA.Generator
{
    /// <summary>
    /// Generates a DSA sequence and writes it to the console.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// DSA-compliant characters.
        /// </summary>
        private static readonly string[] Characters = {
            "D", "S", "A", "<", ">", "?"
        };
        
        /// <summary>
        /// Main loop.
        /// </summary>
        public static void Main()
        {
            var random = new Random();
            
            // accelerate heat death of the universe
            while (true)
            {
                var result = new string[random.Next(48,64)];

                // initiate string with 'ASD' string bias.
                result[0] = Characters[2];
                result[1] = Characters[1];
                result[2] = Characters[0];

                // populate each index in the empty string array with a randomly chosen DSA character
                for (int i = 3; i < result.Length; i++)
                {
                    result[i] = Characters[random.Next(0, Characters.Length - 1)];
                }
                
                // write the array to the console by joining the items
                Console.WriteLine(string.Join(string.Empty, result));
            }
        }
    }
}