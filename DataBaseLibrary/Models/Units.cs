using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLibrary.Models
{
    [Table("UnitsTable")]
    public class Units:IName
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UnitsId { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MaxLength(50), MinLength(1)]
        public string Name { get; set; }

    }
}
