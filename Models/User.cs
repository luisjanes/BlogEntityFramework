using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogEntityFramework.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        [Column(TypeName="VARCHAR")]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        [Column(TypeName = "VARCHAR")]
        public string Email { get; set; }

        [Required]
        [MaxLength(255)]
        [Column(TypeName = "VARCHAR")]
        public string PasswordHash { get; set; }

        [Required]
        [Column(TypeName = "text")]
        public string Bio { get; set; }

        [Required]
        [MaxLength(2000)]
        [Column(TypeName = "VARCHAR")]
        public string Image { get; set; }

        [Required]
        [MaxLength(80)]
        [Column(TypeName = "VARCHAR")]
        public string Slug { get; set; }
    }
}
