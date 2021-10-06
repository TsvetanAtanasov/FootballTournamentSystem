﻿namespace FootballTournamentSystem.Infrastructure.Persistence.Repositories.Person.Referee
{
    using Domain.Models.Person.Referee;
    using FootballTournamentSystem.Application.Features.Person.Referee;

    internal class RefereeRepository : FootballTournamentDataRepository<Referee>, IRefereeRepository
    {
        public RefereeRepository(FootballTournamentDbContext db)
            : base(db)
        {

        }
    }
}
