using eProdaja.Model.Requests;
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

        [HttpPost()]
        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            return korisniciService.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.Korisnici Update(int id, KorisniciUpdateRequest request)
        {
            return korisniciService.Update(id, request);
        }
    }
}
