namespace Core.Domain.Exceptions
{
    public class InvalidTournamentStatisticsException : BaseDomainException
    {
        public InvalidTournamentStatisticsException()
        {

        }

        public InvalidTournamentStatisticsException(string message) => this.Message = message;
    }
}
