namespace FootballTournamentSystem.Domain.Exceptions
{
    using Core.Domain;

    public class InvalidFinalsException : BaseDomainException
    {
        public InvalidFinalsException()
        {

        }

        public InvalidFinalsException(string message) => this.Message = message;
    }
}
