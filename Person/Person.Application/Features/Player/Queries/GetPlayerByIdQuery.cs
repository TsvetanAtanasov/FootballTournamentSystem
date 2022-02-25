namespace Person.Application.Features.Player.Queries
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Core.Application;
    using MediatR;
    using FootballTournamentSystem.Person.Application.Features.Player;

    public class GetPlayerByIdQuery : EntityCommand<int>, IRequest<GetPlayerByIdOutputModel>
    {
        public GetPlayerByIdQuery(Guid playerGuid)
        {
            this.PlayerGuid = playerGuid;
        }

        public Guid PlayerGuid { get; set; }

        public class GetPlayerByIdQueryHandler : IRequestHandler<GetPlayerByIdQuery, GetPlayerByIdOutputModel>
        {
            private readonly IPlayerRepository playerRepository;

            public GetPlayerByIdQueryHandler(IPlayerRepository playerRepository)
            {
                this.playerRepository = playerRepository;
            }

            public async Task<GetPlayerByIdOutputModel> Handle(
                GetPlayerByIdQuery request,
                CancellationToken cancellationToken)
            {
                var player = await this.playerRepository.GetPlayerById(
                    request.PlayerGuid,
                    cancellationToken);

                return new GetPlayerByIdOutputModel(player.FirstName, player.LastName, player.ImageUrl, player.TeamId);
            }
        }
    }
}
