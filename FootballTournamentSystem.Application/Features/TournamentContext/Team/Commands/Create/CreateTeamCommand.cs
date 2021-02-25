namespace FootballTournamentSystem.Application.Features.TournamentContext.Team.Commands.Create
{
    using Domain.Factories.TournamentContext.Tournament;
    using Application.Features.TournamentContext.Team.Common;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;
    using Domain.Factories.TournamentContext.Team;

    public class CreateTeamCommand : TeamCommand<CreateTeamCommand>, IRequest<CreateTeamOutputModel>
    {
        public class CreateTeamCommandHandler : IRequestHandler<CreateTeamCommand, CreateTeamOutputModel>
        {
            private readonly ITeamRepository teamRepository;
            private readonly ITeamFactory teamFactory;

            public CreateTeamCommandHandler(ITeamRepository teamRepository, ITeamFactory teamFactory)
            {
                this.teamRepository = teamRepository;
                this.teamFactory = teamFactory;
            }

            public async Task<CreateTeamOutputModel> Handle(CreateTeamCommand request, CancellationToken cancellationToken)
            {
                var team = this.teamFactory
                    .WithName(request.Name)
                    .WithLogoUrl(request.LogoUrl)
                    .WithYearFounded(request.YearFounded)
                    .WithPresident(request.PresidentFirstName, request.PresidentLastName, request.PresidentImageUrl)
                    .WithCoach(request.CoachFirstName, request.CoachLastName, request.CoachImageUrl)
                    .WithCountry(request.Country)
                    .WithStadium(request.Stadium)
                    .WithGroupPoints(request.GroupPoints)
                    .Build();

                await this.teamRepository.Save(team, cancellationToken);

                return new CreateTeamOutputModel(team.Id);
            }
        }
    }
}
