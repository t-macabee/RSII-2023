using AutoMapper;
using eProdaja.Model;
using eProdaja.Model.Requests.ProizvodiRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services.StateMachine.ProizvodiStateMachine
{
    public class InitialProductState : BaseState
    {
        public InitialProductState(IServiceProvider provider, Database.EProdajaContext context, IMapper mapper) : base(provider, context, mapper)
        {
        }

        public override async Task<Proizvodi> Insert(ProizvodiInsertRequest request)
        {
            var set = context.Set<Database.Proizvodi>();

            var entity = mapper.Map<Database.Proizvodi>(request);

            entity.StateMachine = "draft";

            set.Add(entity);

            await context.SaveChangesAsync();

            return mapper.Map<Proizvodi>(entity);
        }
    }
}
