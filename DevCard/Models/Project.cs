namespace DevCard.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }

        public Project(int id, string name, string image, string description, string client)
        {
            Id = id;
            Name = name;
            Image = image;
            Description = description;
            Client = client;
        }
    }

}
