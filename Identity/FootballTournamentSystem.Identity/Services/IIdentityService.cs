namespace FootballTournamentSystem.Identity.Services
{
    using System.Threading.Tasks;
    using Core.Application;
    using Data.Models;

    public interface IIdentityService
    {
        Task<Result<User>> Register(UserInputModel userInput);

        Task<Result<UserOutputModel>> Login(UserInputModel userInput);

        Task<Result> ChangePassword(string userId, ChangePasswordInputModel changePasswordInput);
    }
}
