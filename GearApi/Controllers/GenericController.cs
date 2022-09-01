using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GearApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T, R> : ControllerBase where T : BaseModel where R : BaseRepository<T>
    {
        private R repository;

        public GenericController()
        {
            this.repository = Activator.CreateInstance<R>();
        }

        [HttpGet]
        public List<T> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return repository.GetById(id);
        }

        [HttpPost]
        public string Post(T entity)
        {
            return repository.Create(entity);
        }

        [HttpDelete]
        public string Delete(int id)
        {
            return repository.Delete(id);
        }

        [HttpPut]
        public string Put(T entity)
        {
            return repository.Update(entity);
        }
    }
}
