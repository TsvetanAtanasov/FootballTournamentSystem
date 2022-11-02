namespace FootballTournamentSystem.Person.Application.Features.Player.Commands.Create
{
    using Core.Application.Messages;
    using FootballTournamentSystem.Person.Domain.Factories.Player;
    using MassTransit;
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
            private readonly IPlayerFactory playerFactory;
            private readonly IBus publisher;

            public CreatePlayerCommandHandler(
                IPlayerRepository playerRepository,
                IPlayerFactory playerFactory,
                IBus publisher)
            {
                this.playerRepository = playerRepository;
                this.playerFactory = playerFactory;
                this.publisher = publisher;
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

                await this.publisher.Publish(new PlayerCreatedMessage
                {
                    PlayerGuid = player.Guid,
                    TeamId = player.TeamId
                });

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
