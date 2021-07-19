namespace FootballTournamentSystem.Domain.Exceptions
{
    using global::Common.Domain;

    public class InvalidMatchStatisticsException : BaseDomainException
    {
        public InvalidMatchStatisticsException()
        {

        }

        public InvalidMatchStatisticsException(string message) => this.Message = message;
    }
}
