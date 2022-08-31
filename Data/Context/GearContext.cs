using Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class GearContext : DbContext
    {
        #region Props
        public DbSet<UserModel> User { get; set; }
        public DbSet<CategoryModel> Category { get; set; }
        public DbSet<ProductModel> Product { get; set; }
        public DbSet<SaleModel> Sale { get; set; }
        public DbSet<AddressModel> Address { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=zuplae.vps-kinghost.net; Port=5443; Database=db_gear; UserId=postgres; Password=123456");
        }
    }
}
