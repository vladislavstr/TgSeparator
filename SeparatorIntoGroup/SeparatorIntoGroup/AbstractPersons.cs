using SeparatorIntoGroup.Options;

namespace SeparatorIntoGroup
{
    public class AbstractPersons
    {
        public int Id { get; protected set; }
        public string NamePersons { get; protected set; }
        public string Accaunt { get; protected set; }
        public StatusType Status { get; protected set; }

        public virtual void Writeinfo()
        {
            Console.WriteLine($"{Id}");
            Console.WriteLine($"{NamePersons}");
            Console.WriteLine($"{Accaunt}");
            Console.WriteLine($"{Status}");
        }
    }
}
