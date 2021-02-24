namespace FootballTournamentSystem.Application.Features.TournamentContext.Tournament.Queries.Groups
{
    using MediatR;

    public class GetTournamentGroupsQuery : EntityCommand<int>, IRequest<TournamentGroupsOutputModel>
    {
    }
}
