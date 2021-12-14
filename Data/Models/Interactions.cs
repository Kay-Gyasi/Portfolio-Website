using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Interactions
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [MaxLength(40)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Column(TypeName = "varchar(15)")]
        public string Phone { get; set; }

        [DataType(DataType.Text)]
        public string Type { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(200)]
        public string Details { get; set; }

        public bool isResponded { get; set; } = false;
    }
}
