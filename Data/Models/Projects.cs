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
        [MaxLength(150)]
        [Required]
        public string Link { get; set; }

        [MaxLength(300)]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        [MaxLength(200)]
        [DataType(DataType.Text, ErrorMessage = "Input is invalid")]
        public string ImgLink { get; set; }

    }
}
