using eProdaja.Services.Database;
using eProdaja.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services.Services
{
    public class KorisniciService : IKorisniciService
    {
        private EProdajaContext context;
        public KorisniciService(EProdajaContext context)
        {
            this.context = context;
        }

        public List<Model.Korisnici> Get()
        {
            var entityList = context.Korisnicis.ToList();            
        }
    }
}
