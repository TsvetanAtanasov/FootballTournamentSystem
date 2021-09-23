namespace FootballTournamentSystem.Domain.Models.Person.Referee
{
    public class Referee : Person
    {
        internal Referee(string firstName, string lastName, string imageUrl)
            : base(firstName, lastName, imageUrl)
        {
        }

        private Referee()
            : base()
        {

        }
    }
}
