namespace FootballTournamentSystem.Application.Features.TournamentContext.Team.Commands.Create
{
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
                    .WithCountry(request.Country)
                    .WithStadium(request.Stadium)
                    .WithGroupPoints(request.GroupPoints)
                    .Build();

                // in infrastucture layer - save coach and president?
                await this.teamRepository.Save(team, cancellationToken);

                return new CreateTeamOutputModel(team.Id);
            }
        }
    }
}
