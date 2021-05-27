namespace FootballTournamentSystem.Application.Features.PersonContext.President.Commands.Create
{
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;
    using Domain.Factories.PersonContext.President;
    using Application.Features.TournamentContext.Team;

    public class CreatePresidentCommand : IRequest<CreatePresidentOutputModel>
    {
        public CreatePresidentCommand(string firstName, string lastName, string imageUrl, int teamId)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ImageUrl = imageUrl;
            this.TeamId = teamId;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public string ImageUrl { get; }

        public int TeamId { get; }

        public class CreatePresidentCommandHandler : IRequestHandler<CreatePresidentCommand, CreatePresidentOutputModel>
        {
            private readonly IPresidentRepository presidentRepository;
            private readonly ITeamRepository teamRepository;
            private readonly IPresidentFactory presidentFactory;

            public CreatePresidentCommandHandler(IPresidentRepository presidentRepository, ITeamRepository teamRepository, IPresidentFactory presidentFactory)
            {
                this.presidentRepository = presidentRepository;
                this.teamRepository = teamRepository;
                this.presidentFactory = presidentFactory;
            }

            public async Task<CreatePresidentOutputModel> Handle(CreatePresidentCommand request, CancellationToken cancellationToken)
            {
                var president = this.presidentFactory
                    .WithFirstName(request.FirstName)
                    .WithLastName(request.LastName)
                    .WithImageUrl(request.ImageUrl)
                    .Build();

                await this.presidentRepository.Save(president, cancellationToken);

                if (request.TeamId != 0)
                {
                    var team = await this.teamRepository.GetTeamById(request.TeamId);
                    team.AddPresident(president.Id);
                }

                return new CreatePresidentOutputModel(president.Id);
            }
        }
    }
}
