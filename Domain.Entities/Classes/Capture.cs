using Domain.Entities.Interfaces;

namespace Domain.Entities.Classes
{
    public class Capture : IEntityPostgresDB<int>
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Index { get; set; }
        public int Length { get; set; }

        // Конструктор без параметров.
        public Capture() { }

        // Конструктор с параметрами.
        public Capture(string text, int index, int length)
        {
            Text = text;
            Index = index;
            Length = length;
        }
    }
}