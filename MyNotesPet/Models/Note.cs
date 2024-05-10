namespace MyNotesPet.Models
{
    public class Note
    {
        public Note(string title, string description)
        {
            Title = title; 
            Description = description;
            CreatedAt = DateTime.Now; // по умолчанию дата создания
        }
        public Guid Id { get; init; }
        public string Title { get; init; } 
        public string Description { get; init; }
        public DateTime CreatedAt { get; init; }
    }
}

//string.Empty - по умолчанию пустая строка