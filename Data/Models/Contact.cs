using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        [DataType(DataType.Text)]
        [Column(TypeName = "varchar(20)")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Url)]
        [MaxLength(50)]
        public string Link { get; set; }
    }
}
