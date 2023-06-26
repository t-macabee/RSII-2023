using eProdaja.Model;
using eProdaja.Services.Interfaces;
using eProdaja.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JediniceMjereController : BaseController<Model.JediniceMjere>
    {
        public JediniceMjereController(IJediniceMjereService service) : base(service)
        {
        }
    }
}
