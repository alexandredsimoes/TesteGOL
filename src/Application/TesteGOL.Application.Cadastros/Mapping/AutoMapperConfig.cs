using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MiniApps.Imovel.Application.Cadastro.Mapping
{
    public class AutoMapperConfig
    {

        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.ShouldMapField = (f)=> false;
                cfg.ShouldMapProperty = (f) => false;
                cfg.AddProfile(new ViewModelToDomainMappingProfile());
                cfg.AddProfile(new DomainToViewModelMappingProfile());                
            });
        }
    }
}
