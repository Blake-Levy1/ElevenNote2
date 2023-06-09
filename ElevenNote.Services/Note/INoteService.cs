using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public interface INoteService
{
    Task<bool> CreateNoteAsync(NoteCreate request);
    Task<IEnumerable<NoteListItem>> GetAllNotesAsync();
    Task<NoteDetail> GetNoteByIdAsync(int noteId);
    Task<bool> UpdateNoteAsync(NoteUpdate request);
}