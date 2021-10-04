namespace FootballTournamentSystem.Application.Features.Tournament.Tournament
{
    using Contracts;
    using Domain.Models.Tournament.Tournament;
    using Features.Tournament.Tournament.Common;
    using Features.Tournament.Tournament.Queries.TournamentGroups;
    using Features.Tournament.Tournament.Queries.TournamentMatches;
    using Features.Tournament.Team.Common;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using FootballTournamentSystem.Application.Features.Tournament.Tournament.Queries.TournamentGroups.GroupMatches;

    public interface ITournamentRepository : IRepository<Tournament>
    {
        Task<bool> TournamentExists(int tournamentId, CancellationToken cancellationToken = default);

        Task<bool> Delete(int tournamentId, CancellationToken cancellationToken = default);

        Task<IEnumerable<TournamentOutputModel>> GetTournaments(CancellationToken cancellationToken = default);

        Task<Tournament> GetTournamentById(int tournamentId, CancellationToken cancellationToken = default);

        Task<IEnumerable<GetTournamentGroupOutputModel>> GetTournamentGroups(int tournamentId, CancellationToken cancellationToken = default);

        // get group matches + final matches in one query
        Task<IEnumerable<GetTournamentMatchOutputModel>> GetTournamentMatches(int tournamentId, CancellationToken cancellationToken = default);

        Task<IEnumerable<TeamOutputModel>> GetTournamentTeams(IList<int> groupIds, CancellationToken cancellationToken = default);

        Task<IEnumerable<TeamOutputModel>> GetGroupTeams(int groupId, CancellationToken cancellationToken = default);

        Task<IEnumerable<GetGroupMatchOutputModel>> GetGroupMatches(int groupId, CancellationToken cancellationToken = default);
    }
}
