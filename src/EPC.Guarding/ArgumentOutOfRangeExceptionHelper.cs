using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace EPC.Guarding
{
    /// <summary>
    /// Extension of <see cref="ArgumentOutOfRangeException"/> static methods
    /// </summary>
    public static class ArgumentOutOfRangeExceptionHelper
    {
        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="arg"/> length is not equal to <paramref name="length"/>.
        /// </summary>
        /// <param name="arg"></param>
        /// <param name="length"></param>
        /// <param name="argName"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        [DebuggerStepThrough]
        public static void ThrowIfNullOrNotEqualLength([NotNull] string? arg, int length, [CallerArgumentExpression(nameof(arg))] string? argName = default)
        {
            ArgumentNullException.ThrowIfNull(arg, argName);
            ArgumentOutOfRangeException.ThrowIfNotEqual(arg.Length, length, $"{argName}.{nameof(arg.Length)}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="arg"/> length exceed <paramref name="maxLength"/>.
        /// </summary>
        /// <param name="arg"></param>
        /// <param name="length"></param>
        /// <param name="argName"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        [DebuggerStepThrough]
        public static void ThrowIfNullOrLengthExceedMax([NotNull] string? arg, int maxLength, [CallerArgumentExpression(nameof(arg))] string? argName = default)
        {
            ArgumentNullException.ThrowIfNull(arg, argName);
            ArgumentOutOfRangeException.ThrowIfGreaterThan(arg.Length, maxLength, $"{argName}.{nameof(arg.Length)}");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="arg"/> is not null and length is not equal to <paramref name="length"/>.
        /// </summary>
        /// <param name="arg"></param>
        /// <param name="length"></param>
        /// <param name="argName"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        [DebuggerStepThrough]
        public static void ThrowIfNotNullAndNotEqualLength(string? arg, int length, [CallerArgumentExpression(nameof(arg))] string? argName = default)
        {
            if (arg is not null)
            {
                ArgumentOutOfRangeException.ThrowIfNotEqual(arg.Length, length, $"{argName}.{nameof(arg.Length)}");
            }
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="arg"/> has no element.
        /// </summary>
        /// <param name="arg"></param>
        /// <param name="length"></param>
        /// <param name="argName"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        [DebuggerStepThrough]
        public static void ThrowIfEmpty<T>(IReadOnlyCollection<T> arg, [CallerArgumentExpression(nameof(arg))] string? argName = default)
        {
            ArgumentNullException.ThrowIfNull(arg);

            if (arg.Count == 0)
            {
                throw new ArgumentOutOfRangeException(argName, $"Collection cannot be empty");
            }
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="arg"/> has null element.
        /// </summary>
        /// <param name="arg"></param>
        /// <param name="length"></param>
        /// <param name="argName"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        [DebuggerStepThrough]
        public static void ThrowIfAnyNullElement<T>(IReadOnlyCollection<T> arg, [CallerArgumentExpression(nameof(arg))] string? argName = default)
        {
            ArgumentNullException.ThrowIfNull(arg);

            foreach (var item in arg)
            {
                if (item is null)
                {
                    throw new ArgumentOutOfRangeException(argName, $"Collection cannot contains null element");
                }
            }
        }

        /// <summary>
        /// Throw <see cref="ArgumentOutOfRangeException"/> if <paramref name="arg"/> is not defined for it's enum.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arg"></param>
        /// <param name="argName"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        [DebuggerStepThrough]
        public static void ThrowIfNotDefined<T>(T arg, [CallerArgumentExpression(nameof(arg))] string? argName = default) where T : struct, Enum
        {
            if (Enum.IsDefined(arg) is false)
            {
                throw new ArgumentOutOfRangeException(argName, $"Value is not defined ({typeof(T).Name} : {arg})");
            }
        }
    }
}
