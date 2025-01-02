namespace EPC.Monetary.Helper
{
    /// <summary>
    /// Helper class for CurrencyCode
    /// </summary>
    public static class CurrencyCodeHelper
    {
        /// <summary>
        /// Converts a currency code string to a corresponding CurrencyCode enum value.
        /// </summary>
        /// <param name="currencyCodeString">The currency code string to convert (e.g., "USD", "EUR", etc.).</param>
        /// <returns>The corresponding CurrencyCode enum value.</returns>
        /// <exception cref="InvalidCastException">Thrown if the conversion is not possible.</exception>
        public static CurrencyCode Parse(string currencyCodeString)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(currencyCodeString);

            if (Enum.TryParse<CurrencyCode>(currencyCodeString, ignoreCase: true, out var result))
            {
                return result;
            }

            throw new InvalidCastException($"Could not convert {currencyCodeString} to {typeof(CurrencyCode).FullName}");
        }
    }
}
