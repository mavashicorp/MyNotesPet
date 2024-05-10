using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyNotesPet.Contracts;
using MyNotesPet.DataAccess;
using MyNotesPet.Models;

namespace MyNotesPet.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly NotesDbContext _dbContext;
        public NotesController(NotesDbContext dbContext) {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateNoteRequest request, CancellationToken ct)
        {
            var note = new Note(request.Title, request.Description);

            await _dbContext.Notes.AddAsync(note, ct);
            await _dbContext.SaveChangesAsync();//нужен для сохранения данных в базе данных

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get(GetNotesRequest request, CancellationToken ct)
        {
            var notesQuery = _dbContext.Notes
            .Where(n => !string.IsNullOrWhiteSpace(request.Search) &&
                    n.Title.ToLower().Contains(request.Search.ToLower()));

            if (request.SortOrder == "desc")
            {
                notesQuery = notesQuery.OrderByDescending(nameof => nameof.CreatedAt);
            }
            else
            {
                notesQuery = notesQuery.OrderBy(nameof=>nameof.CreatedAt);
            }

            var noteDtos = await notesQuery
                .Select(n => new NoteDto(n.Id, n.Title, n.Description, n.CreatedAt))
                .ToListAsync(CancellationToken: ct);

            return Ok(new GetNotesResponse(noteDtos));
            
        }
    }
}
