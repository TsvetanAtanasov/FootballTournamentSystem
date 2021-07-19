namespace FootballTournamentSystem.Domain.Exceptions
{
    using global::Common.Domain;

    public class InvalidPlayerStatisticsException : BaseDomainException
    {
        public InvalidPlayerStatisticsException()
        {

        }

        public InvalidPlayerStatisticsException(string message) => this.Message = message;
    }
}
