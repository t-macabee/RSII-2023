using eProdaja.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VrsteProizvodaController : BaseController<Model.VrsteProizvoda, object>
    {
        public VrsteProizvodaController(IService<Model.VrsteProizvoda, object> service) : base(service)
        {
        }
    }
}
