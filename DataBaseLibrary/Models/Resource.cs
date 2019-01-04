using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBaseLibrary.Models
{
    [Table("ResourceTable")]
    internal class Resource
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ResourceId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Details { get; set; }

        [ForeignKey("ImageId")]
        public Image Image { get; set; }

        
    }
}
