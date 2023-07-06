using AutoMapper;
using eProdaja.Model.Requests.ProizvodiRequests;
using eProdaja.Model.SearchObjects;
using eProdaja.Services.Database;
using eProdaja.Services.Interfaces;

namespace eProdaja.Services.Services
{
    public class ProizvodiService : BaseCRUDService<Model.Proizvodi, Database.Proizvodi, ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>, IProizvodiService
    {
        public ProizvodiService(EProdajaContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
