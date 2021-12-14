using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class Projects
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DataType(DataType.Text)]
        [Required]
        public string Name { get; set; }

        [DataType(DataType.Url)]
        [MaxLength(80)]
        [Required]
        public string Link { get; set; }

        [MaxLength(300)]
        [DataType(DataType.Text)]
        public string Description { get; set; }

    }
}
