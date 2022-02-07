namespace Core.Domain.Exceptions
{
    public class InvalidTournamentException : BaseDomainException
    {
        public InvalidTournamentException()
        {

        }

        public InvalidTournamentException(string message) => this.Message = message;
    }
}
