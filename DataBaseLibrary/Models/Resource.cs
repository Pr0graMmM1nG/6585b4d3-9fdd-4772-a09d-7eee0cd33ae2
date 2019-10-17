using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBaseLibrary.Models
{
    [Table("ResourceTable")]
   public class Resource:IName
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ResourceId { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MaxLength(50), MinLength(1)]
        public string Name { get; set; }

        public string Details { get; set; }

        
        public Image Image { get; set; }

        
    }
}
