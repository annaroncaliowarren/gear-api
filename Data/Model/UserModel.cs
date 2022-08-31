using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Data.Model
{
    public class UserModel : BaseModel
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Birthday { get; set; }
        public string Company { get; set; }
        public string Cnpj { get; set; }
        public string? Telephone { get; set; }
        public string Cellphone { get; set; }
        [Column(TypeName = "BYTEA")]
        public byte[] Image { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
