namespace MyNotesPet.Contracts
{
    public record GetNotesRequest(string? Search, string? SortItem, string? SortOrder);
    //? для того что бы данные могли быть null
}
