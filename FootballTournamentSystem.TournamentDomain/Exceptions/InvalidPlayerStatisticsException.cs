namespace FootballTournamentSystem.Domain.Exceptions
{
    public class InvalidPlayerStatisticsException : BaseDomainException
    {
        public InvalidPlayerStatisticsException()
        {

        }

        public InvalidPlayerStatisticsException(string message) => this.Message = message;
    }
}
