namespace FootballTournamentSystem.Application.Features.TournamentContext.Tournament
{
    using Contracts;
    using Domain.Models.TournamentContext.Tournament;
    using Features.TournamentContext.Tournament.Queries.All;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public interface ITournamentRepository : IRepository<Tournament>
    {
        Task<bool> TournamentExists(int tournamentId, CancellationToken cancellationToken = default);

        Task<bool> Delete(int tournamentId, CancellationToken cancellationToken = default);

        Task<IEnumerable<GetTournamentOutputModel>> GetTournaments(CancellationToken cancellationToken = default);
    }
}
