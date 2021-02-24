namespace FootballTournamentSystem.Application.Features.TournamentContext.Tournament.Queries.All
{
    using MediatR;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public class GetAllTournamentsQuery : IRequest<IEnumerable<GetTournamentOutputModel>>
    {
        public class GetAllTournamentsQueryHandler : IRequestHandler<GetAllTournamentsQuery, IEnumerable<GetTournamentOutputModel>>
        {
            private readonly ITournamentRepository tournamentRepository;

            public GetAllTournamentsQueryHandler(ITournamentRepository tournamentRepository)
            {
                this.tournamentRepository = tournamentRepository;
            }
            
            public async Task<IEnumerable<GetTournamentOutputModel>> Handle(GetAllTournamentsQuery request, CancellationToken cancellationToken)
            {
                return await this.tournamentRepository.GetTournaments();
            }
        }
    }
}
