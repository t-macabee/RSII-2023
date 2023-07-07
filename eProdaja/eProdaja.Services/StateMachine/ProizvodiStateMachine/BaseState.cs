using AutoMapper;
using eProdaja.Model.Requests.ProizvodiRequests;
using eProdaja.Services.Database;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services.StateMachine.ProizvodiStateMachine
{
    public class BaseState 
    {
        protected EProdajaContext context;
        protected IMapper mapper;
        protected IServiceProvider provider;

        public BaseState(IServiceProvider provider, EProdajaContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
            this.provider = provider;
        }

        public virtual Task<Model.Proizvodi> Insert(ProizvodiInsertRequest request)
        {
            throw new Exception("Not allowed!");
        }

        public virtual Task<Model.Proizvodi> Update(int id, ProizvodiUpdateRequest request)
        {
            throw new Exception("Not allowed!");
        }

        public virtual Task<Model.Proizvodi> Delete(int id)
        {
            throw new Exception("Not allowed!");
        }

        public virtual Task<Model.Proizvodi> Activate(int id)
        {
            throw new Exception("Not allowed!");
        }

        public virtual Task<Model.Proizvodi> Hide(int id)
        {
            throw new Exception("Not allowed!");
        }

        public BaseState CreateState(string stateName)
        {
            switch (stateName)
            {
                case "initial":
                    return provider.GetService<InitialProductState>();
                    break;
                case "draft":
                    return provider.GetService<DraftProductState>();
                    break;
                case "active":
                    return provider.GetService<ActiveProductState>();
                    break;
                default:
                    throw new Exception("Not allowed!");
            }
        }
    }
}
