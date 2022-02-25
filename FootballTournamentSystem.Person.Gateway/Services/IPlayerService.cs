namespace FootballTournamentSystem.Person.Gateway.Services
{
    using System.Threading.Tasks;
    using FootballTournamentSystem.Person.Gateway.Models;
    using Refit;

    public interface IPlayerService
    {
        [Get("/PlayerById")]
        Task<PlayerViewOutputModel> GetPlayerById(
            [Query(CollectionFormat.Multi)] int playerId);
    }
}
