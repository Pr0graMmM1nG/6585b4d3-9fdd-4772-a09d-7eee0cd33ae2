using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBaseLibrary.Models
{
    [Table("PriceTable")]
    public class Price
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long PriceId { get; set; }

       
        public Resource Resource { get; set; }

        
        public Units Unit { get; set; }

        [Required]
        public double Value { get; set; }

        [Required]
        public DateTime Data { get; set; }


        public string Details { get; set; }

        public Furnizor Furnizor { get; set; }
    }
}
