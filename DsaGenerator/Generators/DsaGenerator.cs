using System;

namespace DsaGenerator.Generators
{
    /// <summary>
    ///     DSA-compliant string generator.
    /// </summary>
    public class DsaGenerator : Generator
    {
        /// <inheritdoc />
        protected override string[] Characters { get; } =
        {
            "A", "S", "D", "<", ">", "?"
        };

        /// <inheritdoc />
        public override string Get()
        {
            var random = new Random();
            var result = new string[random.Next(48, 64)];

            // initiate string with 'DSA' string bias
            result[0] = Characters[2];
            result[1] = Characters[1];
            result[2] = Characters[0];

            // populate each index in the empty string array with a randomly chosen DSA character
            for (int i = 3; i < result.Length; i++) result[i] = Characters[random.Next(0, Characters.Length)];

            // write the array to the console by joining the items
            return string.Join(string.Empty, result);
        }
    }
}