namespace FootballTournamentSystem.Domain.Exceptions
{
    using global::Common.Domain;

    public class InvalidFinalsException : BaseDomainException
    {
        public InvalidFinalsException()
        {

        }

        public InvalidFinalsException(string message) => this.Message = message;
    }
}
