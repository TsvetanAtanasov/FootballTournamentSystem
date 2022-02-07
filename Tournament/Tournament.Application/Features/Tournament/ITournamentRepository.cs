namespace FootballTournamentSystem.Application.Features.Tournament.Tournament
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Core.Application.Contracts;
    using FootballTournamentSystem.Tournament.Application.Features.Team.Common;
    using FootballTournamentSystem.Tournament.Application.Features.Tournament.Common;
    using FootballTournamentSystem.Tournament.Application.Features.Tournament.Queries.TournamentGroups;
    using FootballTournamentSystem.Tournament.Application.Features.Tournament.Queries.TournamentGroups.GroupMatches;
    using FootballTournamentSystem.Tournament.Application.Features.Tournament.Queries.TournamentMatches;
    using FootballTournamentSystem.Tournament.Domain.Models.Tournament;

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
