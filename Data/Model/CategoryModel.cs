using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Data.Model
{
    public class CategoryModel : BaseModel
    {
        public string Name { get; set; }
        [Column(TypeName = "BYTEA")]
        public byte[] Image { get; set; }
        public ICollection<ProductModel>? Products { get; set; }
        public int UserId { get; set; }
        [JsonIgnore]
        public UserModel? User { get; set; }
    }
}
