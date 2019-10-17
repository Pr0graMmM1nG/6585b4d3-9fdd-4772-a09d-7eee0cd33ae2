using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBaseLibrary.Models
{
    [Table("ImageTable")]
    public class Image:IName

    {
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long ImageId { get; set; }

    [Required]
    [Index(IsUnique = true)]
    [MaxLength(50), MinLength(1)]
        public string Name { get; set; }

    public byte[] File { get; set; }

    }
}
