using AutoMapper;
using eProdaja.Model.Requests.ProizvodiRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services.StateMachine.ProizvodiStateMachine
{
    public class ActiveProductState : BaseState
    {
        public ActiveProductState(IServiceProvider provider, Database.EProdajaContext context, IMapper mapper) : base(provider, context, mapper)
        {
        }

        
    }
}
