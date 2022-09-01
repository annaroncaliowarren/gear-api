using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Data.Model
{
    public class ProductModel : BaseModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "BYTEA")]
        public byte[] Image { get; set; }
        public int CategoryId { get; set; }

        [JsonIgnore]

        [ForeignKey("CategoryId")]
        public CategoryModel? Category { get; set; }
    }
}