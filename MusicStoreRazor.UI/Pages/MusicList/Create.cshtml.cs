using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MusicStoreRazor.UI.Models;

namespace MusicStoreRazor.UI.Pages.MusicList
{
    public class CreateModel : PageModel
    {
        private readonly MusicStoreListContext _db;
        public CreateModel(MusicStoreListContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Music Music { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                 await _db.Musics.AddAsync(Music);
                 await _db.SaveChangesAsync();
                 return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
