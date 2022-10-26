namespace FootballTournamentSystem.Tournament.Infrastructure.Repositories.Tournament
{
    using System.Threading.Tasks;
    using System.Threading;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using FootballTournamentSystem.Application.Features.Tournament.Tournament;
    using FootballTournamentSystem.Tournament.Domain.Models.Tournament;
    using FootballTournamentSystem.Tournament.Application.Features.Tournament.Queries.TournamentGroups.GroupMatches;
    using FootballTournamentSystem.Tournament.Application.Features.Team.Common;
    using FootballTournamentSystem.Tournament.Application.Features.Tournament.Queries.TournamentGroups;
    using FootballTournamentSystem.Tournament.Application.Features.Tournament.Queries.TournamentMatches;
    using FootballTournamentSystem.Tournament.Application.Features.Tournament.Common;
    using FootballTournamentSystem.Tournament.Infrastructure.Persistance;
    using FootballTournamentSystem.Tournament.Infrastructure.Repositories;

    internal class TournamentRepository : FootballTournamentDataRepository<Tournament>, ITournamentRepository
    {
        public TournamentRepository(TournamentDbContext db)
            : base(db)
        {

        }

        public async Task<bool> Delete(int tournamentId, CancellationToken cancellationToken = default)
        {
            var tournament = await this.Data.Tournaments.FirstOrDefaultAsync(t => t.Id == tournamentId, cancellationToken);

            this.Data.Tournaments.Remove(tournament);

            await this.Data.SaveChangesAsync(cancellationToken);

            return true;
        }

        public async Task<IEnumerable<GetGroupMatchOutputModel>> GetGroupMatches(int groupId, CancellationToken cancellationToken = default)
        {
            var group = await this.Data.Groups.FirstOrDefaultAsync(g => g.Id == groupId, cancellationToken);
            var matches = group.Matches;

            return await matches
                .Select(match => new GetGroupMatchOutputModel(
                    match.Id,
                    match.HomeTeam.Name,
                    match.HomeTeam.LogoUrl,
                    match.AwayTeam.Name,
                    match.AwayTeam.LogoUrl))
                .AsQueryable()
                .ToListAsync();
        }

        public async Task<IEnumerable<TeamOutputModel>> GetGroupTeams(int groupId, CancellationToken cancellationToken = default)
        {

            //TODO add event

            var group = await this.Data.Groups.FirstOrDefaultAsync(g => g.Id == groupId, cancellationToken);
            var teams = group.Teams;
            var result = new List<TeamOutputModel>();

            var teamIds = teams.Select(t => t.Id).ToList();

            //var presidents = await this.Data
            //    .Presidents
            //    .Where(pr => teamIds.Contains(pr.TeamId))
            //    .ToListAsync();

            //foreach (var team in teams)
            //{
            //    // TODO: bulk get presidents?
            //    var president = await this.Data.Presidents.FindAsync(team.PresidentId);
            //    var coach = await this.Data.Coaches.FindAsync(team.CoachId);
            //    result.Add(new TeamOutputModel(
            //        team.Id,
            //        team.Name,
            //        team.LogoUrl,
            //        team.YearFounded,
            //        president.FirstName,
            //        president.LastName,
            //        president.ImageUrl,
            //        coach.FirstName,
            //        coach.LastName,
            //        coach.ImageUrl,
            //        team.Country,
            //        team.Stadium,
            //        team.GroupPoints));
            //}

            return await result.AsQueryable().ToListAsync();
        }

        public async Task<Tournament> GetTournamentById(int tournamentId, CancellationToken cancellationToken = default)
        {
            return await this.Data.Tournaments.FirstOrDefaultAsync(t => t.Id == tournamentId, cancellationToken);
        }

        public async Task<IEnumerable<GetTournamentGroupOutputModel>> GetTournamentGroups(int tournamentId, CancellationToken cancellationToken = default)
        {
            var tournament = await this.All().Where(t => t.Id == tournamentId).FirstOrDefaultAsync(cancellationToken);

            if (tournament == null!)
            {
                return Enumerable.Empty<GetTournamentGroupOutputModel>();
            }
            var groups = tournament.Groups;
            var result = new List<GetTournamentGroupOutputModel>();

            return await groups
                .Select(group => new GetTournamentGroupOutputModel(
                    group.Id,
                    group.Name,
                    group.Teams.Select(t => t.Name),
                    group.Teams.Select(t => t.LogoUrl)))
                .AsQueryable()
                .ToListAsync();
        }

        public async Task<IEnumerable<GetTournamentMatchOutputModel>> GetTournamentMatches(int tournamentId, CancellationToken cancellationToken = default)
        {
            var tournament = await this.Data.Tournaments.FirstOrDefaultAsync(t => t.Id == tournamentId, cancellationToken);
            var matches = tournament.Matches;
            var result = new List<GetTournamentMatchOutputModel>();

            return await matches
                .Select(match => new GetTournamentMatchOutputModel(
                    match.Id,
                    match.HomeTeam.Name,
                    match.HomeTeam.LogoUrl,
                    match.AwayTeam.Name,
                    match.AwayTeam.LogoUrl))
                .AsQueryable()
                .ToListAsync();
        }

        public async Task<IEnumerable<TournamentOutputModel>> GetTournaments(CancellationToken cancellationToken = default)
        {
            return await this.All()
                .Select(t => new TournamentOutputModel(
                    t.Id,
                    t.Name,
                    t.Groups.Count))
                .ToListAsync();
        }

        public async Task<IEnumerable<TeamOutputModel>> GetTournamentTeams(IList<int> groupIds, CancellationToken cancellationToken = default)
        {
            var teams = new List<TeamOutputModel>();
            foreach (var groupId in groupIds)
            {
                var groupTeams = await this.GetGroupTeams(groupId, cancellationToken);
                teams.AddRange(groupTeams);
            }

            return teams;
        }

        public async Task<bool> TournamentExists(int tournamentId, CancellationToken cancellationToken = default)
        {
            var tournaments = await this.Data.Tournaments.ToListAsync();

            return tournaments.Any(t => t.Id == tournamentId);
        }
    }
}
