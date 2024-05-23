using System.Globalization;

namespace MyNotesPet.Contracts
{
    public record GetNotesResponse(List<NoteDto> notes);
}
