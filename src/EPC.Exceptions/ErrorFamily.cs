namespace EPC.Exceptions
{
    /// <summary>
    /// Define general error genre
    /// </summary>
    public enum ErrorFamily
    {
        /// <summary>
        /// Error come from a business check
        /// </summary>
        Business = 1,
        /// <summary>
        /// Error is caused by anything not related to business
        /// </summary>
        Technical = 2,
        /// <summary>
        /// Error is caused by an inexistant entity
        /// </summary>
        NotFound = 3
    }
}
