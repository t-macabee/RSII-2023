using eProdaja.Services.Database;
using eProdaja.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    public class KorisniciController : BaseAPIController
    {
        private IKorisniciService korisniciService;

        public KorisniciController(IKorisniciService korisniciService)
        {
            this.korisniciService = korisniciService;
        }

        [HttpGet()]
        public IEnumerable<Model.Korisnici> Get()
        {
            return korisniciService.Get();
        }
    }
}
