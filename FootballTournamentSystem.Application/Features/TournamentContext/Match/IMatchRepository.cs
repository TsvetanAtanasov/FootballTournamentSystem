namespace FootballTournamentSystem.Application.Features.TournamentContext.Match
{
    using Application.Contracts;
    using Domain.Models.TournamentContext.Match;
    using Features.TournamentContext.Team.Common;
    using Features.TournamentContext.Group.Queries.GroupMatches;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IMatchRepository : IRepository<Match>
    {

    }
}