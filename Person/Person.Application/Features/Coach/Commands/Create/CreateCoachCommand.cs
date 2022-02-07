namespace FootballTournamentSystem.Person.Application.Features.Coach.Commands.Create
{
    using Core.Application.Messages;
    using Core.Domain.Models;
    using FootballTournamentSystem.Person.Domain.Factories.Coach;
    using MassTransit;
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
            private readonly IBus publisher;

            public CreateCoachCommandHandler(
                ICoachRepository coachRepository,
                ICoachFactory coachFactory,
                IBus publisher)
            {
                this.coachRepository = coachRepository;
                this.coachFactory = coachFactory;
                this.publisher = publisher;
            }

            public async Task<CreateCoachOutputModel> Handle(CreateCoachCommand request, CancellationToken cancellationToken)
            {
                var coach = this.coachFactory
                    .WithFirstName(request.FirstName)
                    .WithLastName(request.LastName)
                    .WithImageUrl(request.ImageUrl)
                    .WithTeamId(request.TeamId)
                    .Build();

                var messageData = new CoachCreatedMessage
                {
                    TeamId = coach.TeamId,
                    CoachId = coach.Id
                };

                var message = new Message(messageData);

                await this.coachRepository.Save(coach, cancellationToken, message);

                await this.publisher.Publish(messageData);

                await this.coachRepository.MarkMessageAsPublished(message.Id);

                return new CreateCoachOutputModel(coach.Id);
            }
        }
    }
}
