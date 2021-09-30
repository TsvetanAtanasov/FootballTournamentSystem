namespace FootballTournamentSystem.Application.Features.Person.Player.Commands.Create
{
    using Domain.Factories.Person.Player;
    using Application.Features.TournamentContext.Team;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    // This command can be used for free agents
    public class CreatePlayerCommand : IRequest<CreatePlayerOutputModel>
    {
        public CreatePlayerCommand(string firstName, string lastName, double height, double weight, string imageUrl, int teamId)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Height = height;
            this.Weight = weight;
            this.ImageUrl = imageUrl;
            this.TeamId = teamId;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public double Height { get; } 

        public double Weight { get; }

        public string ImageUrl { get; }

        public int TeamId { get; }

        public class CreatePlayerCommandHandler : IRequestHandler<CreatePlayerCommand, CreatePlayerOutputModel>
        {
            private readonly IPlayerRepository playerRepository;
            private readonly ITeamRepository teamRepository;
            private readonly IPlayerFactory playerFactory;

            public CreatePlayerCommandHandler(IPlayerRepository playerRepository, ITeamRepository teamRepository, IPlayerFactory playerFactory)
            {
                this.playerRepository = playerRepository;
                this.teamRepository = teamRepository;
                this.playerFactory = playerFactory;
            }

            public async Task<CreatePlayerOutputModel> Handle(CreatePlayerCommand request, CancellationToken cancellationToken)
            {
                var player = this.playerFactory
                    .WithFirstName(request.FirstName)
                    .WithLastName(request.LastName)
                    .WithHeight(request.Height)
                    .WithWeight(request.Weight)
                    .WithImageUrl(request.ImageUrl)
                    .WithTeamId(request.TeamId)
                    .Build();

                await this.playerRepository.Save(player, cancellationToken);

                //There is a question about this code in the notes
                //if (request.TeamId != 0)
                //{
                //    var team = await this.teamRepository.GetTeamById(request.TeamId);
                //    team.AddPlayer(player.Id);
                //}

                return new CreatePlayerOutputModel(player.Id);
            }
        }
    }
}
