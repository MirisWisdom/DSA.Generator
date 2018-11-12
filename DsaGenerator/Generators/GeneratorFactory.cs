using System;

namespace DsaGenerator.Generators
{
    /// <summary>
    ///     Gets a Generator instance.
    /// </summary>
    public static class GeneratorFactory
    {
        /// <summary>
        ///     Supported irony expression algorithm types.
        /// </summary>
        public enum Type
        {
            /// <summary>
            ///     LO7 amusement expression algorithm.
            /// </summary>
            Lo7,

            /// <summary>
            ///     DSA interest expression algorithm.
            /// </summary>
            Dsa
        }

        /// <summary>
        ///     Gets a Generator instance based on the inbound Type value.
        /// </summary>
        /// <param name="type">
        ///     Generator type.
        /// </param>
        /// <returns>
        ///     Generator instance.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Invalid enum value given.
        /// </exception>
        public static Generator Get(Type type)
        {
            switch (type)
            {
                case Type.Lo7:
                    return new Lo7Generator();
                case Type.Dsa:
                    return new DsaGenerator();
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}