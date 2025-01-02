namespace EPC.Monetary.Extensions
{
    /// <summary>
    /// Decimal extensions for Money type
    /// </summary>
    public static class DecimalExtensions
    {
        /// <summary>
        /// Wrap decimal value into Money type with currency code
        /// </summary>
        /// <param name="value"></param>
        /// <param name="currencyCode"></param>
        /// <returns></returns>
        public static Money ToMoney(this decimal value, CurrencyCode currencyCode)
        {
            return new Money(value, currencyCode);
        }
    }
}
