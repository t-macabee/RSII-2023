using eProdaja.Model;
using eProdaja.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProizvodiController : ControllerBase
    {
        public IProizvodiService proizvodiService { get; set; }

        public ProizvodiController(IProizvodiService proizvodiService)
        {
            this.proizvodiService = proizvodiService;
        }

        [HttpGet()]
        public IEnumerable<Proizvodi> Get()
        {
            return proizvodiService.Get();
        }
    }
}