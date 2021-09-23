namespace FootballTournamentSystem.Domain.Models.Person.Coach
{
    public class Coach : Person
    {
        internal Coach(string firstName, string lastName, string imageUrl)
            : base(firstName, lastName, imageUrl)
        {
        }

        private Coach() 
            : base()
        {

        }
    }
}
