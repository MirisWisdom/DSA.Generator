namespace DSA.Generator.Generators
{
    /// <summary>
    /// Abstract type representing a string generator.
    /// </summary>
    public abstract class Generator
    {
        /// <summary>
        /// Valid characters for a string generation algorithm.
        /// </summary>
        protected abstract string[] Characters { get; }

        /// <summary>
        /// Retrieves a generated string using the given algorithm.
        /// </summary>
        /// <returns>
        /// The generated string using the given algorithm..
        /// </returns>
        public abstract string Get();
    }
}