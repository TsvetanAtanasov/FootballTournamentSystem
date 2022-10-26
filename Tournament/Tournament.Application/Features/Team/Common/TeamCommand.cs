namespace FootballTournamentSystem.Tournament.Application.Features.Team.Common
{
    using Core.Application;

    public abstract class TeamCommand<TCommand> : EntityCommand<int>
        where TCommand : EntityCommand<int>
    {
        public string Name { get; set; } = default!;

        public string LogoUrl { get; set; } = default!;

        public int YearFounded { get; set; }

        public string Country { get; set; } = default!;

        public string Stadium { get; set; } = default!;

        public int GroupPoints { get; set; }
    }
}
