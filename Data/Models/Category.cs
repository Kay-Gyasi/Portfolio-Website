using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(30)")]
        [DataType(DataType.Text)]
        [Required]
        public string Name { get; set; }
    }
}
