namespace EPC.Exceptions
{
    /// <summary>
    /// Base exception class for technical exception
    /// </summary>
    public class TechnicalException : BaseException
    {
        public override sealed ErrorFamily ErrorFamily => ErrorFamily.Technical;

        public TechnicalException(string code, string message) : base(code, message)
        {
        }

        public TechnicalException(string code, string message, Exception inner) : base(code, message, inner)
        {
        }
    }
}