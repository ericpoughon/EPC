using EPC.Monetary.Exceptions;
using System.Diagnostics.CodeAnalysis;

namespace EPC.Monetary
{
    // https://martinfowler.com/eaaCatalog/money.html
    /// <summary>
    /// Money type
    /// </summary>
    public readonly record struct Money : IEquatable<Money>, IComparable<Money>
    {
        /// <summary>
        /// Amount value
        /// </summary>
        public required decimal Value { get; init; }

        /// <summary>
        /// Currency code
        /// </summary>
        public required CurrencyCode CurrencyCode { get; init; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Money() { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="value"></param>
        /// <param name="currencyCode"></param>
        [SetsRequiredMembers]
        public Money(decimal value, CurrencyCode currencyCode)
        {
            Value = value;
            CurrencyCode = currencyCode;
        }

        /// <summary>
        /// Get currency
        /// </summary>
        /// <returns></returns>
        public Currency GetCurrency() => Currency.AllByCode[CurrencyCode];

        bool HasSameCurrency(Money m) => CurrencyCode == m.CurrencyCode;

        static void CheckSameCurrency(Money m1, Money m2)
        {
            if (!m1.HasSameCurrency(m2))
            {
                throw new CurrencyMismatchException("CURRENCIES_DOES_NOT_MATCH", $"Operation between {m1.CurrencyCode} and {m2.CurrencyCode} is not possible");
            }
        }

        /// <summary>
        /// Display value with currency code
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{Value} {CurrencyCode}";

        /// <summary>
        /// Adjust value according to the direction, positive if credit, else negative
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public Money Sign(Direction direction) => Abs() * (direction is Direction.Credit ? 1 : -1);

        /// <summary>
        /// Change currency if the current currency is no currency or not defined
        /// </summary>
        /// <param name="currencyCode"></param>
        /// <returns></returns>
        public Money AssignIfNoCurrencyDefined(CurrencyCode currencyCode)
        {
            if (CurrencyCode is CurrencyCode.XXX || CurrencyCode == default)
            {
                return this with { CurrencyCode = currencyCode };
            }

            return this;
        }

        #region Math

        /// <summary>
        /// Addition operation with currency equality check
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static Money operator +(Money m1, Money m2)
        {
            CheckSameCurrency(m1, m2);
            return m1 with { Value = m1.Value + m2.Value };
        }

        /// <summary>
        /// Substraction operation with currency equality check
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static Money operator -(Money m1, Money m2)
        {
            CheckSameCurrency(m1, m2);
            return m1 with { Value = m1.Value - m2.Value };
        }

        /// <summary>
        /// Division operation with currency equality check
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static Money operator /(Money m1, Money m2)
        {
            CheckSameCurrency(m1, m2);
            return m1 with { Value = m1.Value / m2.Value };
        }

        /// <summary>
        /// Multiplication operation with currency equality check
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static Money operator *(Money m1, Money m2)
        {
            CheckSameCurrency(m1, m2);
            return m1 with { Value = m1.Value * m2.Value };

        }

        /// <summary>
        /// Addition operation
        /// </summary>
        /// <param name="m"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static Money operator +(Money m, decimal d) => m with { Value = m.Value + d };

        /// <summary>
        /// Substraction operation
        /// </summary>
        /// <param name="m"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static Money operator -(Money m, decimal d) => m with { Value = m.Value - d };

        /// <summary>
        /// Division operation
        /// </summary>
        /// <param name="m"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static Money operator /(Money m, decimal d) => m with { Value = m.Value / d };

        /// <summary>
        /// Multiplication operation
        /// </summary>
        /// <param name="m"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static Money operator *(Money m, decimal d) => m with { Value = m.Value * d };

        /// <summary>
        /// Addition operation
        /// </summary>
        /// <param name="d"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static Money operator +(decimal d, Money m) => m with { Value = d + m.Value };

        /// <summary>
        /// Substraction operation
        /// </summary>
        /// <param name="d"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static Money operator -(decimal d, Money m) => m with { Value = d - m.Value };

        /// <summary>
        /// Division operation
        /// </summary>
        /// <param name="d"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static Money operator /(decimal d, Money m) => m with { Value = d / m.Value };

        /// <summary>
        /// Multiplication operation
        /// </summary>
        /// <param name="d"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static Money operator *(decimal d, Money m) => m with { Value = d * m.Value };

        /// <summary>
        /// Round amount
        /// </summary>
        /// <returns></returns>
        public Money Round() => this with { Value = decimal.Round(Value) };

        /// <summary>
        /// Round amount
        /// </summary>
        /// <param name="decimals"></param>
        /// <returns></returns>
        public Money Round(int decimals) => this with { Value = decimal.Round(Value, decimals) };

        /// <summary>
        /// Round amount
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public Money Round(MidpointRounding mode) => this with { Value = decimal.Round(Value, mode) };

        /// <summary>
        /// Round amount
        /// </summary>
        /// <param name="decimals"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public Money Round(int decimals, MidpointRounding mode) => this with { Value = decimal.Round(Value, decimals, mode) };

        /// <summary>
        /// Round using the currency precision
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public Money RoundToCurrencyPrecision(MidpointRounding mode = MidpointRounding.ToEven)
        {
            var currency = GetCurrency();

            return currency.Precision is not null ? Round(currency.Precision.Value, mode) : Round(mode);
        }

        /// <summary>
        /// Return with absolute amount
        /// </summary>
        /// <returns></returns>
        public Money Abs() => this with { Value = decimal.Abs(Value) };

        /// <summary>
        /// Add percent to the value 
        /// </summary>
        /// <param name="percent"></param>
        /// <returns></returns>
        public Money AddPercent(decimal percent)
        {
            return this with { Value = Value * (1 + percent) };
        }

        /// <summary>
        /// Compare with base amount and return the exceeding percent
        /// </summary>
        /// <param name="baseCompare"></param>
        /// <returns></returns>
        public decimal GetExceedingPercentFrom(Money baseCompare)
        {
            if (baseCompare >= this)
            {
                return 0;
            }

            return (this / baseCompare).Value - 1;
        }

        #endregion

        #region Comparison

        /// <summary>
        /// Greater than, always return false if currencies differs
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator >(Money m1, Money m2) => m1.HasSameCurrency(m2) && m1.Value > m2.Value;

        /// <summary>
        /// Less than, always return false if currencies differs
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator <(Money m1, Money m2) => m1.HasSameCurrency(m2) && m1.Value < m2.Value;

        /// <summary>
        /// Greater than or equal, always return false if currencies differs
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator >=(Money m1, Money m2) => m1.HasSameCurrency(m2) && m1.Value >= m2.Value;

        /// <summary>
        /// Less than or equal, always return false if currencies differs
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator <=(Money m1, Money m2) => m1.HasSameCurrency(m2) && m1.Value <= m2.Value;

        /// <summary>
        /// Equal
        /// </summary>
        /// <param name="m"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool operator ==(Money m, decimal d) => m.Value == d;

        /// <summary>
        /// Not Equal
        /// </summary>
        /// <param name="m"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool operator !=(Money m, decimal d) => m.Value != d;

        /// <summary>
        /// Greater than
        /// </summary>
        /// <param name="m"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool operator >(Money m, decimal d) => m.Value > d;

        /// <summary>
        /// Less than
        /// </summary>
        /// <param name="m"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool operator <(Money m, decimal d) => m.Value < d;

        /// <summary>
        /// Greater than or equal
        /// </summary>
        /// <param name="m"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool operator >=(Money m, decimal d) => m.Value >= d;

        /// <summary>
        /// Less than or equal
        /// </summary>
        /// <param name="m"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool operator <=(Money m, decimal d) => m.Value <= d;

        /// <summary>
        /// Equal
        /// </summary>
        /// <param name="d"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator ==(decimal d, Money m) => m.Value == d;

        /// <summary>
        /// Not Equal
        /// </summary>
        /// <param name="d"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator !=(decimal d, Money m) => m.Value != d;

        /// <summary>
        /// Greater than
        /// </summary>
        /// <param name="d"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator >(decimal d, Money m) => d > m.Value;

        /// <summary>
        /// Less than
        /// </summary>
        /// <param name="d"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator <(decimal d, Money m) => d < m.Value;

        /// <summary>
        /// Greater than or equal
        /// </summary>
        /// <param name="d"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator >=(decimal d, Money m) => d >= m.Value;

        /// <summary>
        /// Less than or equal
        /// </summary>
        /// <param name="d"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator <=(decimal d, Money m) => d <= m.Value;

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        /// <param name="other"></param>
        /// <returns><inheritdoc /></returns>
        public int CompareTo(Money other)
        {
            var currencyCompareTo = CurrencyCode.CompareTo(other.CurrencyCode);
            return currencyCompareTo == 0 ? Value.CompareTo(other.Value) : currencyCompareTo;
        }

        #endregion
    }
}
