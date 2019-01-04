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
    internal class Units
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ForeignKey("Price")]
        public long IdUnits { get; set; }

        [Required]
        public string Name { get; set; }

    }
}
