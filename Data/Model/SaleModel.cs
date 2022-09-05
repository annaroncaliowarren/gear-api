using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Data.Model
{
    public class SaleModel : BaseModel
    {
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Payment { get; set; }
        public string Date { get; set; }
        public int ProductId { get; set; }
        public ProductModel? Product { get; set; }
        public int UserId { get; set; }
        [JsonIgnore]
        public UserModel? User { get; set; }
    }
}