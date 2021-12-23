namespace FootballTournamentSystem.Application.Features.Person.Coach.Commands.Create
{
    using Domain.Factories.Person.Coach;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class CreateCoachCommand : IRequest<CreateCoachOutputModel>
    {
        public CreateCoachCommand(string firstName, string lastName, string imageUrl, int teamId)
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

        public class CreateCoachCommandHandler : IRequestHandler<CreateCoachCommand, CreateCoachOutputModel>
        {
            private readonly ICoachRepository coachRepository;
            private readonly ICoachFactory coachFactory;

            public CreateCoachCommandHandler(ICoachRepository coachRepository, ICoachFactory coachFactory)
            {
                this.coachRepository = coachRepository;
                this.coachFactory = coachFactory;
            }

            public async Task<CreateCoachOutputModel> Handle(CreateCoachCommand request, CancellationToken cancellationToken)
            {
                var coach = this.coachFactory
                    .WithFirstName(request.FirstName)
                    .WithLastName(request.LastName)
                    .WithImageUrl(request.ImageUrl)
                    .Build();

                await this.coachRepository.Save(coach, cancellationToken);

                return new CreateCoachOutputModel(coach.Id);
            }
        }
    }
}
