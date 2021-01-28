namespace FootballTournamentSystem.Domain.Models.TournamentContext.Tournament
{
    using FootballTournamentSystem.Domain.Common;

    public class TournamentType : Enumeration
    {
        public static readonly TournamentType League = new TournamentType(1, nameof(League));
        public static readonly TournamentType Tournament = new TournamentType(2, nameof(Tournament));

        private TournamentType(int value)
            : this(value, FromValue<TournamentType>(value).Name)
        {
        }

        private TournamentType(int value, string name)
            : base(value, name)
        {
        }
    }
}
