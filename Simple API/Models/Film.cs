namespace Simple_API.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        public Film()
        {

        }
        public Film(int id, string? title, string? description)
        {
            Id = id;
            Title = title;
            Description = description;
        }
    }
}
