namespace EPC.Exceptions
{
    /// <summary>
    /// Base exception class for any exception
    /// </summary>
	public abstract class BaseException : Exception
    {
        /// <summary>
        /// General error genre.
        /// </summary>
        public abstract ErrorFamily ErrorFamily { get; }

        /// <summary>
        /// A short, immuable in time, human-readable summary of the error type. 
        /// </summary>
        public string ErrorCode { get; }

        /// <summary>
        /// URI to exception documentation.
        /// </summary>
        public virtual Uri? DocumentationUri { get; }

        public BaseException(string code, string message) : base(message)
        {
            ErrorCode = code;
        }

        public BaseException(string code, string message, Exception inner) : base(message, inner)
        {
            ErrorCode = code;
        }
    }
}
