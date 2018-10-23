using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteGOL.Application.Cadastros.ViewModels;

namespace TesteGOL.Application.Cadastros.Interfaces
{
    public interface IAirplaneAppService
    {
        Task<int> Salvar(AirplaneViewModel viewModel);
        void Remover(Guid Id);
        Task<IPagedList<AirplaneViewModel>> ListarAsync(int pageIndex, int pageSize);
        Task<AirplaneViewModel> SelecionarAsync(Guid Id);                
    }
}
