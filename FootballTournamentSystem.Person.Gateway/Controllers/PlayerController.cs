namespace FootballTournamentSystem.Person.Gateway.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;
    using Core.Web;
    using FootballTournamentSystem.Person.Gateway.Services;
    using FootballTournamentSystem.Person.Gateway.Models;

    public class PlayerController : ApiController
    {
        private readonly IPlayerService playerService;
        private readonly ITeamService teamService;

        public PlayerController(
            IPlayerService playerService,
            ITeamService teamService)
        {
            this.playerService = playerService;
            this.teamService = teamService;
        }

        [HttpGet]
        [Authorize]
        [Route(nameof(PlayerTeamDetails))]
        public async Task<PlayerTeamDetailsViewOutputModel> PlayerTeamDetails(int playerId)
        {
            var player = await this.playerService.GetPlayerById(playerId);

            var team = await this.teamService.GetTeamById(player.TeamId);

            var playerTeamDetails = new PlayerTeamDetailsViewOutputModel()
            {
                FirstName = player.FirstName,
                LastName = player.LastName,
                ImageUrl = player.ImageUrl,
                TeamId = player.TeamId,
                TeamLogo = team.LogoUrl,
                TeamName = team.Name
            };

            return playerTeamDetails;
        }
    }
}
