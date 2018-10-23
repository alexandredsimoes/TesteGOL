using AutoMapper;
using TesteGOL.Application.Cadastros.ViewModels;
using TesteGOL.Domain.Cadastros.Entidades;

namespace MiniApps.Imovel.Application.Cadastro.Mapping
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Airplane, AirplaneViewModel>().ReverseMap();                        
        }
    }
}
