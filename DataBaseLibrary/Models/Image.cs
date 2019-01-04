using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBaseLibrary.Models
{
    [Table("ImageTable")]
    internal class Image
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ImageId { get; set; }

        [Required]
        public string Name { get; set; }

        public byte[] File { get; set; }

    }
}
