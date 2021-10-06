namespace FootballTournamentSystem.Domain.Exceptions
{
    using Core.Domain;

    public class InvalidPlayerStatisticsException : BaseDomainException
    {
        public InvalidPlayerStatisticsException()
        {

        }

        public InvalidPlayerStatisticsException(string message) => this.Message = message;
    }
}
