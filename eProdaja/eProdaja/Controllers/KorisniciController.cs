using eProdaja.Model;
using eProdaja.Model.Requests.KorisniciRequests;
using eProdaja.Model.SearchObjects;
using eProdaja.Services.Interfaces;
using eProdaja.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KorisniciController : BaseCRUDController<Korisnici, KorisniciSearchObject, KorisniciInsertRequest, KorisniciUpdateRequest>
    {
        public KorisniciController(IKorisniciService service) : base(service) { }  

    }
}
