namespace FootballTournamentSystem.Person.Gateway.Services
{
    using System.Threading.Tasks;
    using FootballTournamentSystem.Person.Gateway.Models;
    using Refit;

    public interface ITeamService
    {
        [Get("/TeamById")]
        Task<TeamViewOutputModel> GetTeamById(
            [Query(CollectionFormat.Multi)] int teamId);
    }
}
