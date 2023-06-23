using eProdaja.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services.Interfaces
{
    public interface IKorisniciService
    {
        List<Model.Korisnici> Get();
    }
}
