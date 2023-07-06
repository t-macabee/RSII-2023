using AutoMapper;
using eProdaja.Model;
using eProdaja.Model.Requests.KorisniciRequests;
using eProdaja.Model.Requests.ProizvodiRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Database.Korisnici, Korisnici>();
            CreateMap<KorisniciInsertRequest, Database.Korisnici>();
            CreateMap<KorisniciUpdateRequest, Database.Korisnici>();

            CreateMap<Database.Proizvodi, Proizvodi>();
            CreateMap<ProizvodiInsertRequest, Database.Proizvodi>();
            CreateMap<ProizvodiUpdateRequest, Database.Proizvodi>();

            CreateMap<Database.JediniceMjere, JediniceMjere>();

            CreateMap<Database.VrsteProizvodum, VrsteProizvoda>();

            CreateMap<Database.KorisniciUloge, KorisniciUloge>();

            CreateMap<Database.Uloge, Uloge>();
        }           
    }

}
