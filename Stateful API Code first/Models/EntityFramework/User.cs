
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stateful_API_Code_first.Models.EntityFramework
{
    [Table("t_e_utilisateur_utl")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("utl_id")]
        public int UserId { get; set; }

        [Column("utl_nom")]
        [StringLength(50)]
        public string? Name { get; set; }

        [Column("utl_prenom")]
        [StringLength(50)]
        public string? FirstName { get; set; }

        [Column("utl_pwd")]
        [Required(ErrorMessage = "Le mot de passe est requis.")]
        [StringLength(64)]
        public string Pwd { get; set; } = null!;

        [Column("utl_rue")]
        [StringLength(200)]
        public string? Street { get; set; }

        [Column("utl_ville")]
        [StringLength(50)]
        public string? City { get; set; }

        [Column("utl_mobile", TypeName = "char(10)")]
        public string? Mobile { get; set; }

        [Column("utl_cp", TypeName = "char(5)")]
        public string? PostalCode { get; set; }

        [Column("utl_mail")]
        [EmailAddress(ErrorMessage = "L'adresse e-mail n'est pas valide.")]
        [StringLength(100, MinimumLength = 6)]
        [Required(ErrorMessage = "L'adresse e-mail est requise.")]
        public string Mail { get; set; } = null!;

        [Column("utl_pays")]
        [StringLength(50)]
        public string? Country { get; set; }

        [Column("utl_latitude")]
        public float? Latitude { get; set; }

        [Column("utl_longitude")]
        public float? Longitude { get; set; }

        [Column("utl_datecreation", TypeName = "date")]
        [Required(ErrorMessage = "La date de création est requise.")]
        public DateTime CreationDate { get; set; }

        public virtual ICollection<Rating> UserRatings { get; set; } = new List<Rating>();
    }
}