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
    public class BaseService<T, TDb> : IService<T> where T : class where TDb : class
    {
        private EProdajaContext context;
        public IMapper mapper;

        public BaseService(EProdajaContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<List<T>> Get()
        {
            var query = context.Set<TDb>().AsQueryable();

            var list = await query.ToListAsync();

            return mapper.Map<List<T>>(list);
        }

        public async Task<T> GetById(int id)
        {
            var entity = await context.Set<TDb>().FindAsync(id);

            return mapper.Map<T>(entity);
        }
    }
}
