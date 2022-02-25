namespace FootballTournamentSystem.Person.Application.Features.Common
{
    public class PersonOutputModel
    {
        public PersonOutputModel(string firstName, string lastName, string imageUrl)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ImageUrl = imageUrl;
        }

        public string FirstName { get; set; } = default!;

        public string LastName { get; set; } = default!;

        public string ImageUrl { get; set; } = default!;
    }
}
