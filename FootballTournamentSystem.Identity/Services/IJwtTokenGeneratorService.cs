namespace FootballTournamentSystem.Identity.Services
{
    using System.Collections.Generic;
    using Data.Models;

    public interface ITokenGeneratorService
    {
        string GenerateToken(User user, IEnumerable<string> roles = null);
    }
}
