using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteGOL.Application.Cadastros.ViewModels;
using TesteGOL.Domain.Cadastros.Entidades;

namespace MiniApps.Imovel.Application.Cadastro.Mapping
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName => "ApplicationServiceCadastro";
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<AirplaneViewModel, Airplane>()
                .ConstructUsing(c => new Airplane(c.Id.Value, c.CodigoAviao, c.Modelo, c.Passageiros, c.DataRegistro))
                .ReverseMap();
        }
    }
}
