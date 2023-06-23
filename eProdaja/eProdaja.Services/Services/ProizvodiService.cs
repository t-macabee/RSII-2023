using eProdaja.Model;
using eProdaja.Services.Database;
using eProdaja.Services.Interfaces;

namespace eProdaja.Services.Services
{
    public class ProizvodiService : IProizvodiService
    {
        private EProdajaContext context;

        public ProizvodiService(EProdajaContext context)
        {
            this.context = context;
        }

        List<Model.Proizvodi> proizvodi = new List<Model.Proizvodi>()
        {
            new Model.Proizvodi()
            {
                ProizvoidId = 1,
                Naziv = "Test"
            }
        };        

        public IList<Model.Proizvodi> Get()
        {
            var list = context.Proizvodis.ToList();
            return proizvodi;
        }
    }
}
