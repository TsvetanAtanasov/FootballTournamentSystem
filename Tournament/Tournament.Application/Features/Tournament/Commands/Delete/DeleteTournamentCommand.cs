namespace FootballTournamentSystem.Tournament.Application.Features.Tournament.Commands.Delete
{
    using Core.Application;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;
    using FootballTournamentSystem.Application.Features.Tournament.Tournament;
    using System;

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
                    throw new InvalidOperationException("Invalid tournament id");
                }

               return await this.tournamentRepository.Delete(request.Id, cancellationToken);
            }
        }
    }
}
