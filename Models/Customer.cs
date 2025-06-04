using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDataBase.Models
{
    internal class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [MaxLength(80)]
        [Column(TypeName = "varchar(80)")]
        public string? Email { get; set; }

        public string? CreditCardNumber { get; set; }

        public ICollection<Sale> Sales { get; set; } = new List<Sale>();
    }
}
