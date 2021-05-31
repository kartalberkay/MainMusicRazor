using System.ComponentModel.DataAnnotations;

namespace MusicStoreRazor.UI.Models
{
    public class Music
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Author { get; set; }
        public string BarcodeNumber { get; set; }
    }
}
