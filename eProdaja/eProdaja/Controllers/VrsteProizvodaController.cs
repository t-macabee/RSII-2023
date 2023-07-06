using eProdaja.Model;
using eProdaja.Model.SearchObjects;
using eProdaja.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VrsteProizvodaController : BaseController<VrsteProizvoda, BaseSearchObject>
    {
        public VrsteProizvodaController(IService<VrsteProizvoda, BaseSearchObject> service) : base(service)
        {
        }
    }
}
