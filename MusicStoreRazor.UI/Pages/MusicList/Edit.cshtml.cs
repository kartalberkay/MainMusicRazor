using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MusicStoreRazor.UI.Models;

namespace MusicStoreRazor.UI.Pages.MusicList
{
    public class EditModel : PageModel
    {
        private readonly MusicStoreListContext _db;
        public EditModel(MusicStoreListContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Music Music { get; set; }
        public async Task OnGet(int id)
        {
            Music = await _db.Musics.FindAsync(id);
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var musicFromDb = _db.Musics.FindAsync(Music.Id);
                musicFromDb.Result.Name = Music.Name;
                musicFromDb.Result.Author = Music.Author;
                musicFromDb.Result.BarcodeNumber = Music.BarcodeNumber;
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return RedirectToPage();
            }
        }   
    }
}
