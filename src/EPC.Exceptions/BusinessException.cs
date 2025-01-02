namespace EPC.Exceptions
{
    /// <summary>
    /// Base exception class for business exception
    /// </summary>
    public class BusinessException : BaseException
    {
        public override sealed ErrorFamily ErrorFamily => ErrorFamily.Business;

        public BusinessException(string code, string message) : base(code, message)
        {
        }

        public BusinessException(string code, string message, Exception inner) : base(code, message, inner)
        {
        }
    }
}
