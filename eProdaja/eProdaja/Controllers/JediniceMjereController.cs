using eProdaja.Model;
using eProdaja.Model.SearchObjects;
using eProdaja.Services.Interfaces;
using eProdaja.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JediniceMjereController : BaseController<Model.JediniceMjere, JediniceMjereSearchObject>
    {
        public JediniceMjereController(IJediniceMjereService service) : base(service)
        {
        }
    }
}
