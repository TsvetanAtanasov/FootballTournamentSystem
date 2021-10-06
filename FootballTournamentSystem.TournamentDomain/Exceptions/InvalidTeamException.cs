namespace FootballTournamentSystem.Domain.Exceptions
{
    using Core.Domain;

    public class InvalidTeamException : BaseDomainException
    {
        public InvalidTeamException()
        {

        }

        public InvalidTeamException(string message) => this.Message = message;
    }
}
