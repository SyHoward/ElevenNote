using ElevenNote.Services.Note;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ElevenNote.WebAPI.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class NoteController : ControllerBase
{
    private readonly INoteService _noteService;

    public NoteController(INoteService noteService)
    {
        _noteService = noteService;
    }


    [HttpGet]
    public async Task<IActionResult> GetAllNotes()
    {
        var notes = await _noteService.GetAllNotesAsync();
        return Ok(notes);
    }
}