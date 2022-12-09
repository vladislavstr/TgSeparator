using SeparatorIntoGroup.Options;

namespace SeparatorIntoGroup
{
    internal class AbstractPersons
    {
        public string Id { get; protected set; }
        public string TypePersons { get; protected set; }
        public string NamePersons { get; protected set; }
        public string Accaunt { get; protected set; }
        public StatusType Status { get; protected set; }

        public void Writeinfo()
        {
            Console.WriteLine($"{Id}");
            Console.WriteLine($"{TypePersons}");
            Console.WriteLine($"{NamePersons}");
            Console.WriteLine($"{Accaunt}");
            Console.WriteLine($"{Status}");
        }
    }
}
