namespace SeparatorIntoGroup
{
    public class Team
    {
        public int Id { get; set; }
        public string NameTeam { get; set; }
        public List<Student> StudentsInTeam { get; set; }
        public Team(int id, string name)
        {
            Id = id;
            NameTeam = name;
            StudentsInTeam = new List<Student>();
        }
    }
}