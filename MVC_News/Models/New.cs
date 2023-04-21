using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_News.Models
{
    [Table("New")]
    public class New
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Lenght must be {2}-{1} range")]
        public string? Title { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Lenght must be {2}-{1} range")]
        public string? Subtitle { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        [Display(Name = "Picture URL")]
        public string? NewPictureURL { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }

    }
}
