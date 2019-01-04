using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBaseLibrary.Models
{
    [Table("PriceTable")]
    internal class Price
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdPrice { get; set; }

        [ForeignKey("ResourceId")]
        public Resource Resource { get; set; }

        [ForeignKey("UnitsId")]
        public Units Unit { get; set; }

        [Required]
        public double Value { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [ForeignKey("FurnizorId")]
        public Furnizor Furnizor { get; set; }
    }
}
