using SeparatorIntoGroup.Options;

namespace SeparatorIntoGroup
{
    public class Student: AbstractPersons
    {
        public Student(string name, int id, string accaunt)
        {
            NamePersons = name;
            Id = id;
            Accaunt = accaunt;
            Status = StatusType.NotInGroup;
        }
    }
}
