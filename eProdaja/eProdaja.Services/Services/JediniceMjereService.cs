using AutoMapper;
using eProdaja.Model;
using eProdaja.Model.SearchObjects;
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
    public class JediniceMjereService : BaseService<Model.JediniceMjere, Database.JediniceMjere, JediniceMjereSearchObject>, IJediniceMjereService
    {
        public JediniceMjereService(EProdajaContext context, IMapper mapper) : base(context, mapper) { }

        public override IQueryable<Database.JediniceMjere> AddFilter(IQueryable<Database.JediniceMjere> query, JediniceMjereSearchObject? search = null)
        {
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(search.Naziv));
            }

            if (!string.IsNullOrWhiteSpace(search?.FTS))
            {
                query = query.Where(x => x.Naziv.Contains(search.FTS));
            }

            return base.AddFilter(query, search);
        }
    }
}
