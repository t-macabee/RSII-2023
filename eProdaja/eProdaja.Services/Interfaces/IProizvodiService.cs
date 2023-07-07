using eProdaja.Model;
using eProdaja.Model.Requests.ProizvodiRequests;
using eProdaja.Model.SearchObjects;

namespace eProdaja.Services.Interfaces
{
    public interface IProizvodiService : ICRUDService<Proizvodi, ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>
    {
        Task<Proizvodi> Activate(int id);
    }
}
