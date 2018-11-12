using System;
using System.Collections.Generic;

namespace DsaGenerator.Generators
{
    /// <inheritdoc />
    /// <summary>
    ///     LO7-compliant string generator.
    /// </summary>
    public class Lo7Generator : Generator
    {
        /// <inheritdoc />
        protected override List<string> Characters { get; } = new List<string>
        {
            "L", "O", "A", "7", "8", "9"
        };

        /// <inheritdoc />
        public override string Get()
        {
            var random = new Random();
            var result = new string[random.Next(48, 64)];

            // initiate string with 'LO7' string bias
            result[0] = Characters[0];
            result[1] = Characters[1];
            result[2] = Characters[2];

            // populate each index in the empty string array with a randomly chosen LO7 character
            for (int i = 3; i < result.Length; i++) result[i] = Characters[random.Next(0, Characters.Count)];

            // write the array to the console by joining the items
            return string.Join(string.Empty, result);
        }
    }
}