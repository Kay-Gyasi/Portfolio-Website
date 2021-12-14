using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(20)")]
        [DataType(DataType.Text)]
        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [MaxLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [MaxLength(15)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required]
        public bool isWorking { get; set; } = false;
    }
}
