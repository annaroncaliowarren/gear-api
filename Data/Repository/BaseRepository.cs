using Data.Context;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        public virtual string Create(T entity)
        {
            using (GearContext gearContext = new GearContext())
            {
                gearContext.Add(entity);
                gearContext.SaveChanges();
            }
            return "Cadastro adicionado com sucesso!";
        }

        public virtual string Delete(int id)
        {
            T model = GetById(id);

            using (GearContext gearContext = new GearContext())
            {
                gearContext.Entry<T>(model).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                gearContext.SaveChanges();
            }
            return "Cadastro deletado com sucesso!";
        }

        public virtual List<T> GetAll()
        {
            List<T> entities = new List<T>();

            using (GearContext gearContext = new GearContext())
            {
                entities = gearContext.Set<T>().ToList();
            }
            return entities;
        }

        public virtual T GetById(int id)
        {
            T model = null;

            using (GearContext gearContext = new GearContext())
            {
                model = gearContext.Set<T>().Find(id);
            }
            return model;
        }

        public virtual string Update(T entity)
        {
            using (GearContext gearContext = new GearContext())
            {
                gearContext.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                gearContext.SaveChanges();
            }
            return "Cadastro alterado com sucesso!";
        }
    }
}
