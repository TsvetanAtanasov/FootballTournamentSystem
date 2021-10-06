namespace FootballTournamentSystem.Domain.Exceptions
{
    using Core.Domain;

    public class InvalidTournamentStatisticsException : BaseDomainException
    {
        public InvalidTournamentStatisticsException()
        {

        }

        public InvalidTournamentStatisticsException(string message) => this.Message = message;
    }
}
