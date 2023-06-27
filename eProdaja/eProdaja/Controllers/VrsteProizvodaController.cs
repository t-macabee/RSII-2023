using eProdaja.Model.SearchObjects;
using eProdaja.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VrsteProizvodaController : BaseController<Model.VrsteProizvoda, BaseSearchObject>
    {
        public VrsteProizvodaController(IService<Model.VrsteProizvoda, BaseSearchObject> service) : base(service)
        {
        }
    }
}
