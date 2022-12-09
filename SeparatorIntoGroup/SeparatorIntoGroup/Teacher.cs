using SeparatorIntoGroup.Options;

namespace SeparatorIntoGroup
{
    public class Teacher : AbstractPersons
    {
        public Teacher(string name, int id, string accaunt)
        {
            NamePersons = name;
            Id = id;
            Accaunt = accaunt;
            Status = StatusType.IsTeacher;
        }
    }
}
