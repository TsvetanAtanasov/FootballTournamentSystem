﻿namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.TournamentContext.Tournament
{
    using Domain.Models.TournamentContext.Tournament;
    using Application.Features.TournamentContext.Tournament;
    using Application.Features.TournamentContext.Tournament.Queries.TournamentGroups.GroupMatches;
    using Application.Features.TournamentContext.Team.Common;
    using Application.Features.TournamentContext.Tournament.Queries.TournamentGroups;
    using Application.Features.TournamentContext.Tournament.Queries.TournamentMatches;
    using Application.Features.TournamentContext.Tournament.Common;
    using System.Threading.Tasks;
    using System.Threading;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using FootballTournamentSystem.Domain.Models.TournamentContext.Team;

    internal class TournamentRepository : DataRepository<Tournament>, ITournamentRepository
    {
        public TournamentRepository(FootballTournamentDbContext db)
            : base(db)
        {

        }

        public async Task<bool> Delete(int tournamentId, CancellationToken cancellationToken = default)
        {
            var tournament = await this.Data.Tournaments.FindAsync(tournamentId);

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            if (tournament == null)
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
            {
                return false;
            }

            this.Data.Tournaments.Remove(tournament);

            await this.Data.SaveChangesAsync(cancellationToken);

            return true;
        }

        public async Task<IEnumerable<GetGroupMatchOutputModel>> GetGroupMatches(int groupId, CancellationToken cancellationToken = default)
        {
            var group = await this.Data.Groups.FindAsync(groupId);
            var matches = group.Matches;
            // TODO: null check?
            return await Task.FromResult(matches
                .Select(match => new GetGroupMatchOutputModel(
                    match.Id,
                    match.HomeTeam.Name,
                    match.HomeTeam.LogoUrl,
                    match.AwayTeam.Name,
                    match.AwayTeam.LogoUrl))
                .ToList());
        }

        public async Task<IEnumerable<TeamOutputModel>> GetGroupTeams(int groupId, CancellationToken cancellationToken = default)
        {
            var group = await this.Data.Groups.FindAsync(groupId);
            var teams = group.Teams;
            var result = new List<TeamOutputModel>();
            foreach (var team in teams)
            {
                // TODO: bulk get presidents?
                var president = await this.Data.Presidents.FindAsync(team.PresidentId);
                var coach = await this.Data.Coaches.FindAsync(team.CoachId);
                result.Add(new TeamOutputModel(
                    team.Id,
                    team.Name,
                    team.LogoUrl,
                    team.YearFounded,
                    president.FirstName,
                    president.LastName,
                    president.ImageUrl,
                    coach.FirstName,
                    coach.LastName,
                    coach.ImageUrl,
                    team.Country,
                    team.Stadium,
                    team.GroupPoints));
            }

            return await Task.FromResult(result);
        }

        public async Task<Tournament> GetTournamentById(int tournamentId, CancellationToken cancellationToken = default)
        {
            return await this.Data.Tournaments.FirstOrDefaultAsync(t => t.Id == tournamentId, cancellationToken);
        }

        public async Task<IEnumerable<GetTournamentGroupOutputModel>> GetTournamentGroups(int tournamentId, CancellationToken cancellationToken = default)
        {
            var tournament = await this.Data.Tournaments.FindAsync(tournamentId);
            var groups = tournament.Groups;
            var result = new List<GetTournamentGroupOutputModel>();
            // TODO: null check?
            return await Task.FromResult(groups
                .Select(group => new GetTournamentGroupOutputModel(
                    group.Id,
                    group.Name,
                    group.Teams.Select(t => t.Name),
                    group.Teams.Select(t => t.LogoUrl)))
                .ToList());
        }

        public async Task<IEnumerable<GetTournamentMatchOutputModel>> GetTournamentMatches(int tournamentId, CancellationToken cancellationToken = default)
        {
            var tournament = await this.Data.Tournaments.FindAsync(tournamentId);
            var matches = tournament.Matches;
            var result = new List<GetTournamentMatchOutputModel>();
            // TODO: null check?
            return await Task.FromResult(matches
                .Select(match => new GetTournamentMatchOutputModel(
                    match.Id,
                    match.HomeTeam.Name,
                    match.HomeTeam.LogoUrl,
                    match.AwayTeam.Name,
                    match.AwayTeam.LogoUrl))
                .ToList());
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
            var tournament = await this.Data.Tournaments.FindAsync(tournamentId);

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            return tournament != null;
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        }
    }
}