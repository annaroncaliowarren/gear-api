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
    public class SaleRepository : BaseRepository<SaleModel>
    {
        public override List<SaleModel> GetAll()
        {
            List<SaleModel> list = new List<SaleModel>();

            using (GearContext context = new GearContext())
            {
                list = context.Sale.Include("Product").ToList();
            }

            return list;
        }
    }
}
