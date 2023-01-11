using M4HW3.Configurats;

namespace M4HW3.Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public List<Project> Projects { get; set; } = new List<Project>();
    }
}
