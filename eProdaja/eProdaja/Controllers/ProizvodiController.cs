using eProdaja.Model;
using eProdaja.Model.Requests.KorisniciRequests;
using eProdaja.Model.Requests.ProizvodiRequests;
using eProdaja.Model.SearchObjects;
using eProdaja.Services.Interfaces;
using eProdaja.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProizvodiController : BaseCRUDController<Proizvodi, ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>
    {
        public ProizvodiController(IProizvodiService service) : base(service) { }  
    }
}
