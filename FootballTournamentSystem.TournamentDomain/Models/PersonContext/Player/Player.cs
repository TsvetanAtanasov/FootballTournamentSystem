namespace FootballTournamentSystem.Domain.Models.PersonContext.Player
{
    using FootballTournamentSystem.Domain.Common;
    using FootballTournamentSystem.Domain.Exceptions;

    public class Player : Person
    {
        internal Player(string firstName, string lastName, double height, double weight, string imageUrl)
            : base(firstName, lastName, imageUrl)
        {
            this.Validate(height, weight);

            this.Height = height;
            this.Weight = weight;
        }

        public double Height { get; }

        public double Weight { get; }

        public int PlayerStatisticsId { get; private set; }

        public void AddPlayerStatistics(int statisticsId) => this.PlayerStatisticsId = statisticsId;

        private void Validate(double height, double weight)
        {
            Guard.ForPositiveNumber<InvalidPlayerException>(
            height,
            nameof(this.Height));

            Guard.ForPositiveNumber<InvalidPlayerException>(
            weight,
            nameof(this.Weight));
        }
    }
}
