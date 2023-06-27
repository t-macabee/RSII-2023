using eProdaja.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace eProdaja.Controllers
{    
    public class BaseController<T, TSearch> : ControllerBase where T : class where TSearch : class
    {
        private IService<T, TSearch> service;

        public BaseController(IService<T, TSearch> service)
        {
            this.service = service;
        }

        [HttpGet()]
        public async Task<IEnumerable<T>> Get([FromQuery]TSearch? search = null)
        {
            return await service.Get(search);
        }

        [HttpGet("{id}")]
        public async Task<T> GetById(int id)
        {
            return await service.GetById(id);
        }
    }
}
