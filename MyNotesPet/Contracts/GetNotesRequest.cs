namespace MyNotesPet.Contracts
{
    public class GetNotesRequest(string? Search, string? SortItem, string? SortOrder)
    {
        public string? SortOrder { get; internal set; }
        public object Search { get; internal set; }
    }
    //? для того что бы данные могли быть null
}
