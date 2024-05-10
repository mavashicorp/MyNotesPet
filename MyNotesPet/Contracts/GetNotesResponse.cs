using System.Globalization;

namespace MyNotesPet.Contracts
{
    public record GetNotesResponse(List<NoteDto> notes);
    
    public record NoteDto(Guid Id, string Title, string Discription, DateTime CreatedAt);
}
