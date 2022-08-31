using Data.Context;
using Data.Model;
using Data.Utils;
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
            entity.Password = Cryptography.Encrypt(entity.Password);
            return base.Update(entity);
        }

        public UserModel Logon(string email, string password)
        {
            password = Cryptography.Encrypt(password);
            UserModel user = new UserModel();
            using (GearContext gearContext = new GearContext())
            {
                user = gearContext.User.Where(u => u.Email == email && u.Password == password).FirstOrDefault();
            }
            return user;
        }
    }
}
