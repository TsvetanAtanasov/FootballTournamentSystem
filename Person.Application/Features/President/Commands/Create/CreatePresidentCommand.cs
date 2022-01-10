﻿namespace FootballTournamentSystem.Person.Application.Features.President.Commands.Create
{
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;
    using FootballTournamentSystem.Person.Domain.Factories.President;

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

            public CreatePresidentCommandHandler(IPresidentRepository presidentRepository, IPresidentFactory presidentFactory)
            {
                this.presidentRepository = presidentRepository;
                this.presidentFactory = presidentFactory;
            }

            public async Task<CreatePresidentOutputModel> Handle(CreatePresidentCommand request, CancellationToken cancellationToken)
            {
                var president = this.presidentFactory
                    .WithFirstName(request.FirstName)
                    .WithLastName(request.LastName)
                    .WithImageUrl(request.ImageUrl)
                    .WithTeamId(request.TeamId)
                    .Build();

                await this.presidentRepository.Save(president, cancellationToken);

                return new CreatePresidentOutputModel(president.Id);
            }
        }
    }
}