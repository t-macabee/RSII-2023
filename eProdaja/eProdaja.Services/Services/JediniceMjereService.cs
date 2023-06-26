using AutoMapper;
using eProdaja.Model;
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
    public class JediniceMjereService : BaseService<Model.JediniceMjere, Database.JediniceMjere>, IJediniceMjereService
    {
        public JediniceMjereService(EProdajaContext context, IMapper mapper) : base(context, mapper) { }
    }
}
