using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBaseLibrary.Models
{
    [Table("FurnizorTable")]
    public class Furnizor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long FurnizorId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Details { get; set; }
        
    }
}
