namespace FootballTournamentSystem.Domain.Exceptions
{
    using global::Common.Domain;

    public class InvalidTournamentException : BaseDomainException
    {
        public InvalidTournamentException()
        {

        }

        public InvalidTournamentException(string message) => this.Message = message;
    }
}
