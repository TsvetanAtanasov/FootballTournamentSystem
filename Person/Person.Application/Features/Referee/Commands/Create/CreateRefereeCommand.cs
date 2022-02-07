namespace FootballTournamentSystem.Person.Application.Features.Referee.Commands.Create
{
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;
    using FootballTournamentSystem.Person.Application.Features.President;
    using FootballTournamentSystem.Person.Domain.Factories.Referee;

    public class CreateRefereeCommand : IRequest<CreateRefereeOutputModel>
    {
        public CreateRefereeCommand(string firstName, string lastName, string imageUrl)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ImageUrl = imageUrl;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public string ImageUrl { get; }

        public class CreateRefereeCommandHandler : IRequestHandler<CreateRefereeCommand, CreateRefereeOutputModel>
        {
            private readonly IRefereeRepository refereeRepository;
            private readonly IRefereeFactory refereeFactory;

            public CreateRefereeCommandHandler(IRefereeRepository refereeRepository, IRefereeFactory refereeFactory)
            {
                this.refereeRepository = refereeRepository;
                this.refereeFactory = refereeFactory;
            }

            public async Task<CreateRefereeOutputModel> Handle(CreateRefereeCommand request, CancellationToken cancellationToken)
            {
                var referee = this.refereeFactory
                    .WithFirstName(request.FirstName)
                    .WithLastName(request.LastName)
                    .WithImageUrl(request.ImageUrl)
                    .Build();

                await this.refereeRepository.Save(referee, cancellationToken);

                return new CreateRefereeOutputModel(referee.Id);
            }
        }
    }
}
