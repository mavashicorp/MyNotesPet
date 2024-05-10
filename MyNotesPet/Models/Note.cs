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
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}

//string.Empty - по умолчанию пустая строка