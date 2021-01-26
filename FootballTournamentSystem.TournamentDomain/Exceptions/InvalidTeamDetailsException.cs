namespace FootballTournamentSystem.Domain.Exceptions
{
    public class InvalidTeamDetailsException : BaseDomainException
    {
        public InvalidTeamDetailsException()
        {

        }

        public InvalidTeamDetailsException(string message) => this.Message = message;
    }
}
