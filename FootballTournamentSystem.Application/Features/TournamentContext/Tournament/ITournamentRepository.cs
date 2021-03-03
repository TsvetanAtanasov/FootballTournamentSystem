namespace FootballTournamentSystem.Application.Features.TournamentContext.Tournament
{
    using Contracts;
    using Domain.Models.TournamentContext.Tournament;
    using Features.TournamentContext.Tournament.Common;
    using Features.TournamentContext.Tournament.Queries.TournamentGroups;
    using Features.TournamentContext.Team.Common;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public interface ITournamentRepository : IRepository<Tournament>
    {
        Task<bool> TournamentExists(int tournamentId, CancellationToken cancellationToken = default);

        Task<bool> Delete(int tournamentId, CancellationToken cancellationToken = default);

        Task<IEnumerable<TournamentOutputModel>> GetTournaments(CancellationToken cancellationToken = default);

        Task<Tournament> GetTournamentById(int tournamentId, CancellationToken cancellationToken = default);

        Task<IEnumerable<GetTournamentGroupOutputModel>> GetTournamentGroups(int tournamentId, CancellationToken cancellationToken = default);

        Task<IEnumerable<TeamOutputModel>> GetTournamentTeams(IList<int> groupIds, CancellationToken cancellationToken = default);
    }
}
