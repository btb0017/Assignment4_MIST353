using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoInvestAPI.Entities
{
    public class Date
    {
        [Key]
        [Column(TypeName = "date")]
        public DateTime DateValue { get; set; }
    }
}
