using SeparatorIntoGroup.Options;

namespace SeparatorIntoGroup
{
    internal class Student: AbstractPersons
    {
        public StatusType Status { get; protected set; }

        public override void Writeinfo()
        {
            Console.WriteLine($"{Status}");
        }
    }
}
