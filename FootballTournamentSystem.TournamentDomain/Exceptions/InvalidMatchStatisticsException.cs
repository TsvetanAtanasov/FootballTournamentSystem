namespace FootballTournamentSystem.Domain.Exceptions
{
    using Core.Domain;

    public class InvalidMatchStatisticsException : BaseDomainException
    {
        public InvalidMatchStatisticsException()
        {

        }

        public InvalidMatchStatisticsException(string message) => this.Message = message;
    }
}
