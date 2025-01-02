namespace EPC.Exceptions
{
    /// <summary>
    /// The exception that is thrown when something asked doesn't exist. Equivalent to the <see cref="HttpStatusCode.NotFound"/>.
    /// </summary>
    public class NotFoundException : BaseException
    {
        public override sealed ErrorFamily ErrorFamily => ErrorFamily.NotFound;

        public NotFoundException(string code, string message) : base(code, message)
        {
        }

        public NotFoundException(string code, string message, Exception inner) : base(code, message, inner)
        {
        }
    }
}