namespace FootballTournamentSystem.Domain.Exceptions
{
    public class InvalidTeamException : BaseDomainException
    {
        public InvalidTeamException()
        {

        }

        public InvalidTeamException(string message) => this.Message = message;
    }
}
