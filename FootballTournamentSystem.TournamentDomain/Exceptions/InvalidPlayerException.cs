namespace FootballTournamentSystem.Domain.Exceptions
{
    using Core.Domain;

    public class InvalidPlayerException : BaseDomainException
    {
        public InvalidPlayerException()
        {

        }

        public InvalidPlayerException(string message) => this.Message = message;
    }
}
