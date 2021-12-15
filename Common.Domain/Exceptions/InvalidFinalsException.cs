namespace Core.Domain.Exceptions
{
    public class InvalidFinalsException : BaseDomainException
    {
        public InvalidFinalsException()
        {

        }

        public InvalidFinalsException(string message) => this.Message = message;
    }
}
