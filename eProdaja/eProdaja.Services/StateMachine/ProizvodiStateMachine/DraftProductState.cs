using AutoMapper;
using Azure.Core;
using eProdaja.Model;
using eProdaja.Model.Requests.ProizvodiRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services.StateMachine.ProizvodiStateMachine
{
    public class DraftProductState : BaseState
    {
        public DraftProductState(IServiceProvider provider, Database.EProdajaContext context, IMapper mapper) : base(provider, context, mapper)
        {
        }

        public override async Task<Proizvodi> Update(int id, ProizvodiUpdateRequest request)
        {
            var set = context.Set<Database.Proizvodi>();

            var entity = await set.FindAsync(id);

            mapper.Map(request, entity);

            await context.SaveChangesAsync();

            return mapper.Map<Model.Proizvodi>(entity);
        }

        public override async Task<Proizvodi> Activate(int id)
        {
            var set = context.Set<Database.Proizvodi>();

            var entity = await set.FindAsync(id);

            entity.StateMachine = "active";

            await context.SaveChangesAsync();

            return mapper.Map<Model.Proizvodi>(entity);
        }
    }
}
