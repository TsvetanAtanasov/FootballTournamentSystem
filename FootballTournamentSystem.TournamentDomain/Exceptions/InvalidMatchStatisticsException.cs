namespace FootballTournamentSystem.Domain.Exceptions
{
    public class InvalidMatchStatisticsException : BaseDomainException
    {
        public InvalidMatchStatisticsException()
        {

        }

        public InvalidMatchStatisticsException(string message) => this.Message = message;
    }
}
