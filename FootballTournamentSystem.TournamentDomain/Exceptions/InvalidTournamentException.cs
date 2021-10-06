namespace FootballTournamentSystem.Domain.Exceptions
{
    using Core.Domain;

    public class InvalidTournamentException : BaseDomainException
    {
        public InvalidTournamentException()
        {

        }

        public InvalidTournamentException(string message) => this.Message = message;
    }
}
