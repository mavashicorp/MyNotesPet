using static MyNotesPet.Contracts.NotesDto;

namespace MyNotes.Contracts;

public record GetNotesResponse(List<NoteDto> notes);