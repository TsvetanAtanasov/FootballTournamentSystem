namespace FootballTournamentSystem.Domain.Exceptions
{
    using global::Common.Domain;

    public class InvalidPlayerException : BaseDomainException
    {
        public InvalidPlayerException()
        {

        }

        public InvalidPlayerException(string message) => this.Message = message;
    }
}
