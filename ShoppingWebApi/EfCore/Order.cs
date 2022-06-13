using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingWebApi.EfCore
{
    [Table("order")]
    public class Order
    {
        [Key, Required]
        public int id { get; set; } 
        public virtual Product Product { get; set; }
        public string name { get; set; } = string.Empty;
        public string address { get; set; } = string.Empty;
        public string phone { get;set; } = string.Empty;
    }
}
