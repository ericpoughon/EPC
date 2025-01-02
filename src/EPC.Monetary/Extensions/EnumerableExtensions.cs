namespace EPC.Monetary.Extensions
{
    /// <summary>
    /// Enumerable extensions for Monetary type 
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Computes the sum of a sequence of Money values.
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        /// <param name="selector"></param>
        /// <returns></returns>
        public static Money Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, Money> selector, CurrencyCode? defaultCurrencyCode = null)
        {
            ArgumentNullException.ThrowIfNull(source);
            ArgumentNullException.ThrowIfNull(selector);

            return source.Select(selector).Sum(defaultCurrencyCode);
        }

        /// <summary>
        /// Computes the sum of a sequence of Money values.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static Money Sum(this IEnumerable<Money> source, CurrencyCode? defaultCurrencyCode = null)
        {
            ArgumentNullException.ThrowIfNull(source);

            Money? sum = null;
            foreach (Money value in source)
            {
                if (sum is null)
                {
                    sum = value;
                }
                else
                {
                    checked { sum = sum.Value + value; }
                }
            }

            return sum ?? new Money(0, defaultCurrencyCode ?? CurrencyCode.XXX);
        }
    }
}
