namespace Person.Application.Features.Player.Queries
{
    using FootballTournamentSystem.Person.Application.Features.Common;

    public class GetPlayerByIdOutputModel : PersonOutputModel
    {
        public GetPlayerByIdOutputModel(string firstName, string lastName, string imageUrl, int teamId)
            : base(firstName, lastName, imageUrl)
        {
            this.TeamId = teamId;
        }

        public int TeamId { get; set; }
    }
}
