using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MusicStoreRazor.UI.Models;

namespace MusicStoreRazor.UI.Pages.MusicList
{
    public class IndexModel : PageModel
    {
        private readonly MusicStoreListContext _db;
        public IndexModel(MusicStoreListContext db)
        {
            _db = db;
        }
        public IEnumerable<Music> Musics { get; set; }
        public async Task OnGet()
        {
            Musics = await _db.Musics.ToListAsync();
        }
        public async Task<IActionResult> OnPostDelete(int id)
        {
            var music = await _db.Musics.FindAsync(id);
            if (music == null)
            {
                return RedirectToPage("/Error");
            }
            _db.Musics.Remove(music);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
