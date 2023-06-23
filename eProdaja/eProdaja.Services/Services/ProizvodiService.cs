using eProdaja.Model;
using eProdaja.Services.Interfaces;

namespace eProdaja.Services.Services
{
    public class ProizvodiService : IProizvodiService
    {
        List<Proizvodi> proizvodi = new List<Proizvodi>()
        {
            new Proizvodi()
            {
                ProizvoidId = 1,
                Naziv = "Test"
            }
        };

        public IList<Proizvodi> Get()
        {
            return proizvodi;
        }
    }
}
