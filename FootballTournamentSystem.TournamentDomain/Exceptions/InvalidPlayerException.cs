namespace FootballTournamentSystem.Domain.Exceptions
{
    public class InvalidPlayerException : BaseDomainException
    {
        public InvalidPlayerException()
        {

        }

        public InvalidPlayerException(string message) => this.Message = message;
    }
}
