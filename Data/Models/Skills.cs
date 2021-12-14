using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class Skills
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required]
        public bool isMainSkill { get; set; } = false;
    }
}
