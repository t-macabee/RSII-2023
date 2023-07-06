using eProdaja.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseCRUDController<T, TSearch, TInsert, TUpdate> : BaseController<T, TSearch> where T : class where TSearch : class
    {
        protected new ICRUDService<T, TSearch, TInsert, TUpdate> service;

        public BaseCRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service) : base(service)
        {
            this.service = service;
        }

        [HttpPost]
        public virtual async Task<T> Insert([FromBody]TInsert insert)
        {
            return await service.Insert(insert);
        }

        [HttpPut("{id}")]
        public virtual async Task<T> Update(int id, [FromBody]TUpdate update)
        {
            return await service.Update(id, update);
        }
    }
}
