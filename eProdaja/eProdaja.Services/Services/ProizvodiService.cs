using AutoMapper;
using eProdaja.Model.Requests.ProizvodiRequests;
using eProdaja.Model.SearchObjects;
using eProdaja.Services.Database;
using eProdaja.Services.Interfaces;
using eProdaja.Services.StateMachine.ProizvodiStateMachine;
using System.Resources;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace eProdaja.Services.Services
{
    public class ProizvodiService : BaseCRUDService<Model.Proizvodi, Database.Proizvodi, ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>, IProizvodiService
    {
        public BaseState baseState { get; set; }

        public ProizvodiService(BaseState baseState, EProdajaContext context, IMapper mapper) : base(context, mapper)
        {
            this.baseState = baseState;
        }

        public override Task<Model.Proizvodi> Insert(ProizvodiInsertRequest insert)
        {
            var state = baseState.CreateState("initial");

            return state.Insert(insert);
        }

        public override async Task<Model.Proizvodi> Update(int id, ProizvodiUpdateRequest update)
        {
            var entity = await context.Proizvodis.FindAsync(id);

            var state = baseState.CreateState(entity.StateMachine);

            return await state.Update(id, update);
        }

        public async Task<Model.Proizvodi> Activate(int id)
        {
            var entity = await context.Proizvodis.FindAsync(id);

            var state = baseState.CreateState(entity.StateMachine);

            return await state.Activate(id);
        }
    }
}
