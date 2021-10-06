namespace FootballTournamentSystem.Domain.Exceptions
{
    using Core.Domain;

    public class InvalidGroupException : BaseDomainException
    {
        public InvalidGroupException()
        {

        }

        public InvalidGroupException(string message) => this.Message = message;
    }
}
