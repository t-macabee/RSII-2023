using eProdaja.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace eProdaja.Controllers
{    
    public class BaseController<T> : ControllerBase where T : class
    {
        private IService<T> service;

        public BaseController(IService<T> service)
        {
            this.service = service;
        }

        [HttpGet()]
        public async Task<IEnumerable<T>> Get()
        {
            return await service.Get();
        }

        [HttpGet("{id}")]
        public async Task<T> GetById(int id)
        {
            return await service.GetById(id);
        }
    }
}
