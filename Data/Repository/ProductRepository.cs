using Data.Context;
using Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class ProductRepository : BaseRepository<ProductModel>
    {
        public override List<ProductModel> GetAll()
        {
            List<ProductModel> list = new List<ProductModel>();

            using (GearContext context = new GearContext())
            {
                list = context.Product.Include("Category").ToList();
            }

            return list;
        }
    }
}
