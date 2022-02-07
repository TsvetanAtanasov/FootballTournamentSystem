namespace FootballTournamentSystem.Tournament.Application.Features.Tournament.Queries.All
{
    using MediatR;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using FootballTournamentSystem.Application.Features.Tournament.Tournament;
    using Tournament.Common;

    public class GetAllTournamentsQuery : IRequest<IEnumerable<TournamentOutputModel>>
    {
        public class GetAllTournamentsQueryHandler : IRequestHandler<GetAllTournamentsQuery, IEnumerable<TournamentOutputModel>>
        {
            private readonly ITournamentRepository tournamentRepository;

            public GetAllTournamentsQueryHandler(ITournamentRepository tournamentRepository)
            {
                this.tournamentRepository = tournamentRepository;
            }
            
            public async Task<IEnumerable<TournamentOutputModel>> Handle(GetAllTournamentsQuery request, CancellationToken cancellationToken)
            {
                return await this.tournamentRepository.GetTournaments();
            }
        }
    }
}
