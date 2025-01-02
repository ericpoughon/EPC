using EPC.Exceptions;

namespace EPC.Monetary.Exceptions
{
    internal class CurrencyMismatchException : BusinessException
    {
        public CurrencyMismatchException(string code, string message) : base(code, message)
        {
        }

        public CurrencyMismatchException(string code, string message, Exception inner) : base(code, message, inner)
        {
        }
    }
}
