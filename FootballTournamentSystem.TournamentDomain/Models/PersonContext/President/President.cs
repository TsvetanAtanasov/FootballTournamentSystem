namespace FootballTournamentSystem.Domain.Models.PersonContext.President
{
    public class President : Person
    {
        internal President(string firstName, string lastName, string imageUrl)
            : base(firstName, lastName, imageUrl)
        {
        }

        private President()
            : base()
        {

        }
    }
}
