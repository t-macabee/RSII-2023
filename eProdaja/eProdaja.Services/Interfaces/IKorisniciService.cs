﻿using eProdaja.Model.Requests;
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
        Task<List<Model.Korisnici>> Get();
        Model.Korisnici Insert(KorisniciInsertRequest request);
        Model.Korisnici Update(int id, KorisniciUpdateRequest request);
    }
}
