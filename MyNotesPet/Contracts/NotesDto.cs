namespace MyNotesPet.Contracts
{
    public class NotesDto
    {
        public record NoteDto(Guid Id, string Title, string Discription, DateTime CreatedAt);
    }
}
