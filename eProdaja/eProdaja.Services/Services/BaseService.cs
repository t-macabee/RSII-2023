using AutoMapper;
using eProdaja.Services.Database;
using eProdaja.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services.Services
{
    public class BaseService<T, TDb, TSearch> : IService<T, TSearch> where T : class where TDb : class where TSearch : class
    {
        protected EProdajaContext context;
        protected IMapper mapper;

        public BaseService(EProdajaContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public virtual async Task<List<T>> Get(TSearch? search = null)
        {
            var query = context.Set<TDb>().AsQueryable();

            query = AddFilter(query, search);

            var list = await query.ToListAsync();

            return mapper.Map<List<T>>(list);
        }

        public virtual async Task<T> GetById(int id)
        {
            var entity = await context.Set<TDb>().FindAsync(id);

            return mapper.Map<T>(entity);
        }

        public virtual IQueryable<TDb> AddFilter(IQueryable<TDb> query, TSearch? search = null)
        {
            return query;
        }
    }
}
