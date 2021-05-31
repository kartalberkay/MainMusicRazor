using Microsoft.EntityFrameworkCore;


namespace MusicStoreRazor.UI.Models
{
    public class MusicStoreListContext : DbContext
    {
        public MusicStoreListContext(DbContextOptions<MusicStoreListContext> options) : base(options)
        {

        }


        public DbSet<Music> Musics { get; set; }
    }
}
