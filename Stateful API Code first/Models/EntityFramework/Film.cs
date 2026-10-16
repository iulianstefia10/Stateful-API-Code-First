using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stateful_API_Code_first.Models.EntityFramework
{
    [Table("t_e_film_flm")]
    public class Film
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("flm_id")]
        public int FilmId { get; set; }

        [Required]
        [Column("flm_titre")]
        [StringLength(100, ErrorMessage = "Le titre ne doit pas dépasser 100 caractères.")]
        public string Title { get; set; } = null!;

        [Column("flm_resume", TypeName = "text")]
        public string? Summary { get; set; }

        [Column("flm_datesortie", TypeName = "date")]
        public DateTime? DateRelease { get; set; }

        [Column("flm_duree", TypeName = "numeric(3,0)")]
        public decimal? Duration { get; set; }

        [Column("flm_genre")]
        [StringLength(30, ErrorMessage = "Le genre ne doit pas dépasser 30 caractères.")]
        public string? Gender { get; set; }

        public virtual ICollection<Rating> NotesFilm { get; set; } = new List<Rating>();
    }
}