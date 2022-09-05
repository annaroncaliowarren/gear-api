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
    public class CategoryRepository : BaseRepository<CategoryModel>
    {
        public override List<CategoryModel> GetAll()
        {
            List<CategoryModel> products = new List<CategoryModel>();

            using (GearContext context = new GearContext())
            {
                products = context.Category.Include("Products").ToList();
            }

            return products;
        }

        public List<CategoryModel> GetByUserId(int id)
        {
            List<CategoryModel> products = new List<CategoryModel>();

            using (GearContext context = new GearContext())
            {
                products = context.Category.Include("Products").Include("User").Where(c => c.UserId == id).ToList();
            }

            return products;
        }
    }
}
