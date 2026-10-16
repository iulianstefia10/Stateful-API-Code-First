using Stateful_API_Code_first.Models.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stateful_API_Code_first.Models.EntityFramework
{
    [Table("t_j_notation_not")]
    public class Rating
    {
        [Key]
        [Column("utl_id", Order = 0)]
        public int UserId { get; set; }

        [Key]
        [Column("flm_id", Order = 1)]
        public int FilmId { get; set; }

        [Required]
        [Range(0, 5, ErrorMessage = "La note doit être comprise entre 0 et 5.")]
        [Column("not_note")]
        public int Note { get; set; }

        [ForeignKey("UserId")]
        public virtual User UserNotator { get; set; } = null!;

        [ForeignKey("FilmId")]
        public virtual Film MovieNote { get; set; } = null!;
    }
}