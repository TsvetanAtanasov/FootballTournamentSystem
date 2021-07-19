namespace FootballTournamentSystem.Domain.Exceptions
{
    using global::Common.Domain;

    public class InvalidGroupException : BaseDomainException
    {
        public InvalidGroupException()
        {

        }

        public InvalidGroupException(string message) => this.Message = message;
    }
}
