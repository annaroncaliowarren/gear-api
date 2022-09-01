using Data.Context;
using Data.Model;
using Data.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class UserRepository : BaseRepository<UserModel>
    {
        public override string Create(UserModel entity)
        {
            entity.Password = Cryptography.Encrypt(entity.Password);
            return base.Create(entity);
        }

        public override string Update(UserModel entity)
        {
            var modelOld  = this.GetById(entity.Id);
            entity.Password = modelOld.Password;
            return base.Update(entity);
        }

        public override List<UserModel> GetAll()
        {
            List<UserModel> list = new List<UserModel>();

            using (GearContext context = new GearContext())
            {
                list = context.User.Include("Address").ToList();
            }

            return list;
        }

        public UserModel Logon(string email, string password)
        {
            password = Cryptography.Encrypt(password);
            
            UserModel user = new UserModel();

            using (GearContext gearContext = new GearContext())
            {
                user = gearContext.User.Include("Address").Where(u => u.Email == email && u.Password == password).FirstOrDefault();
            }

            return user;
        }

    }
}
