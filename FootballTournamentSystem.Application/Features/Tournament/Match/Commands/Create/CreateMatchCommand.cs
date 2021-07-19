﻿namespace FootballTournamentSystem.Application.Features.TournamentContext.Match.Commands.Create
{
    using Domain.Factories.TournamentContext.Match;
    using Application.Features.TournamentContext.Team;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class CreateMatchCommand : IRequest<CreateMatchOutputModel>
    {
        public CreateMatchCommand(int homeTeamId, int awayTeamId, int refereeId)
        {
            this.HomeTeamId = homeTeamId;
            this.AwayTeamId = awayTeamId;
            this.RefereeId = refereeId;
        }

        public int HomeTeamId { get; }

        public int AwayTeamId { get; }

        public int RefereeId { get; }

        public class CreateMatchCommandHandler : IRequestHandler<CreateMatchCommand, CreateMatchOutputModel>
        {
            private readonly IMatchRepository matchRepository;
            private readonly ITeamRepository teamRepository;
            private readonly IMatchFactory matchFactory;

            public CreateMatchCommandHandler(IMatchRepository matchRepository, ITeamRepository teamRepository, IMatchFactory matchFactory)
            {
                this.matchRepository = matchRepository;
                this.teamRepository = teamRepository;
                this.matchFactory = matchFactory;
            }

            public async Task<CreateMatchOutputModel> Handle(CreateMatchCommand request, CancellationToken cancellationToken)
            {
                var homeTeam = await teamRepository.GetTeamById(request.HomeTeamId);
                var awayTeam = await teamRepository.GetTeamById(request.AwayTeamId);

                var match = this.matchFactory
                    .WithHomeTeam(homeTeam)
                    .WithAwayTeam(awayTeam)
                    .Build();

                await this.matchRepository.Save(match, cancellationToken);

                return new CreateMatchOutputModel(match.Id);
            }
        }
    }
}