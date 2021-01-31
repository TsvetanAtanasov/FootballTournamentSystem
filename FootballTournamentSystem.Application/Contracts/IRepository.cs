﻿namespace CarRentalSystem.Application.Contracts
{
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using FootballTournamentSystem.Domain.Common;

    public interface IRepository<out TEntity>
        where TEntity : IAggregateRoot
    {
        IQueryable<TEntity> All();

        Task<int> SaveChanges(CancellationToken cancellationToken = default);
    }
}
