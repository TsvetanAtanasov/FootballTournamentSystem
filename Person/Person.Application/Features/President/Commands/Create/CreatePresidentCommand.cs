namespace FootballTournamentSystem.Person.Application.Features.President.Commands.Create
{
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;
    using FootballTournamentSystem.Person.Domain.Factories.President;
    using MassTransit;
    using Core.Application.Messages;
    using Core.Domain.Models;

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
            private readonly IPresidentFactory presidentFactory;
            private readonly IBus publisher;

            public CreatePresidentCommandHandler(
                IPresidentRepository presidentRepository, 
                IPresidentFactory presidentFactory,
                IBus publisher)
            {
                this.presidentRepository = presidentRepository;
                this.presidentFactory = presidentFactory;
                this.publisher = publisher;
            }

            public async Task<CreatePresidentOutputModel> Handle(CreatePresidentCommand request, CancellationToken cancellationToken)
            {
                var president = this.presidentFactory
                    .WithFirstName(request.FirstName)
                    .WithLastName(request.LastName)
                    .WithImageUrl(request.ImageUrl)
                    .WithTeamId(request.TeamId)
                    .Build();

                var messageData = new PresidentCreatedMessage
                {
                    TeamId = president.TeamId,
                    PresidentGuid = president.Guid
                };

                var message = new Message(messageData);

                await this.presidentRepository.Save(president, cancellationToken, message);

                await this.publisher.Publish(messageData);

                await this.presidentRepository.MarkMessageAsPublished(message.Id);

                return new CreatePresidentOutputModel(president.Id);
            }
        }
    }
}
