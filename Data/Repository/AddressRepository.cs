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
    public class AddressRepository : BaseRepository<AddressModel>
    {
        public override List<AddressModel> GetAll()
        {
            List<AddressModel> list = new List<AddressModel>();

            using (GearContext context = new GearContext())
            {
                list = context.Address.Include("User").ToList();
            }
            return list;
        }
    }
}
