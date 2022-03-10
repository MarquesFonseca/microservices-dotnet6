using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Models
{
    public abstract class BaseProduct
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
    }
}
