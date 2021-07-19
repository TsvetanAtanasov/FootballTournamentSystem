namespace FootballTournamentSystem.Domain.Exceptions
{
    using global::Common.Domain;

    public class InvalidTournamentStatisticsException : BaseDomainException
    {
        public InvalidTournamentStatisticsException()
        {

        }

        public InvalidTournamentStatisticsException(string message) => this.Message = message;
    }
}
