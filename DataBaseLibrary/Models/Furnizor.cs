using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBaseLibrary.Models
{
    [Table("FurnizorTable")]
    public class Furnizor:IName
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long FurnizorId { get; set; }
   
        [Required]
        [Index(IsUnique = true)]
        [MaxLength(50),MinLength(1)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Details { get; set; }

        
        
    }
}
