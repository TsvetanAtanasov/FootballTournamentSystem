namespace FootballTournamentSystem.Application.Features.TournamentContext.Match
{
    using Application.Contracts;
    using Domain.Models.TournamentContext.Match;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IMatchRepository : IRepository<Match>
    {
        Task<Match> GetMatchById(int teamId, CancellationToken cancellationToken = default);
    }
}