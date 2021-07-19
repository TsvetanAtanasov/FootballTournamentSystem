namespace FootballTournamentSystem.Application.Features.TournamentContext.Tournament.Commands.Delete
{
    using global::Common.Application;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class DeleteTournamentCommand : EntityCommand<int>, IRequest<Result>
    {

        public class DeleteTournamentCommandHandler : IRequestHandler<DeleteTournamentCommand, Result>
        {
            private readonly ITournamentRepository tournamentRepository;

            public DeleteTournamentCommandHandler(ITournamentRepository tournamentRepository)
            {
                this.tournamentRepository = tournamentRepository;
            }

            public async Task<Result> Handle(DeleteTournamentCommand request, CancellationToken cancellationToken)
            {
                var tournamentExists = await this.tournamentRepository.TournamentExists(request.Id);

                if (!tournamentExists)
                {
                    return "Invalid tournament id";
                }

               return await this.tournamentRepository.Delete(request.Id, cancellationToken);
            }
        }
    }
}
