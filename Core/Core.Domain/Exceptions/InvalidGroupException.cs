namespace Core.Domain.Exceptions
{
    public class InvalidGroupException : BaseDomainException
    {
        public InvalidGroupException()
        {

        }

        public InvalidGroupException(string message) => this.Message = message;
    }
}
