using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using TesteGOL.Application.Cadastros.Interfaces;
using TesteGOL.Application.Cadastros.ViewModels;
using TesteGOL.Domain.Cadastros.Entidades;
using TesteGOL.Domain.Core.Bus;

namespace TesteGOL.Application.Cadastros.Services
{
    public class AirplaneAppService : IAirplaneAppService
    {
        private readonly IUnitOfWork _unityOfWork;
        private readonly IRepository<Airplane> _repository;
        private IMediatorHandler _mediator;
        //private IEventStore _eventStore;

        public AirplaneAppService(IUnitOfWork unityOfWork, IMediatorHandler mediator/*, IEventStore eventStore*/)
        {
            //_eventStore = eventStore;
            _mediator = mediator;
            _unityOfWork = unityOfWork;
            _repository = unityOfWork.GetRepository<Airplane>();
        }

        public async Task<int> Salvar(AirplaneViewModel viewModel)
        {
            //Mapeia a viewModel para model
            Airplane model = viewModel.ToModel();
            if (model.Id == Guid.Empty)
            {
                await _repository.InsertAsync(model);
            }
            else
            {
                _repository.Update(model);
            }

            try
            {
                return await _unityOfWork.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IPagedList<AirplaneViewModel>> ListarAsync(int pageIndex, int pageSize)
        {
            return await _repository.GetPagedListAsync(orderBy: f => f.OrderByDescending(d => d.DataRegistro),
                selector: s => new AirplaneViewModel()
                {
                    Id = s.Id,
                    CodigoAviao = s.CodigoAviao,
                    DataRegistro = s.DataRegistro,
                    Modelo = s.Modelo,
                    Passageiros = s.Passageiros
                });
        }

        public void Remover(Guid Id)
        {
            _repository.Delete(new Airplane(Id, null, null, 0, DateTime.MinValue));
            _unityOfWork.SaveChanges();
        }

        public async Task<AirplaneViewModel> SelecionarAsync(Guid Id)
        {
            var item = await _repository.GetFirstOrDefaultAsync(predicate: p => p.Id == Id,
                disableTracking: true,
                selector: s => new AirplaneViewModel()
                {
                    Id = s.Id,
                    CodigoAviao = s.CodigoAviao,
                    DataRegistro = s.DataRegistro.Date,
                    Modelo = s.Modelo,
                    Passageiros = s.Passageiros
                });

            return item;
        }

        //public async Task<bool> RemoverComplemento(ImovelComplementoViewModel imovelComplementoViewModel)
        //{
        //    ImovelComplemento model = Mapper.Map<ImovelComplemento>(pessoaTelefoneViewModel);

        //    _unityOfWork.GetRepository<ImovelComplemento>().Delete(model);
        //    return await _unityOfWork.SaveChangesAsync() > 0;
        //}

        public void Remover(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IPagedList<AirplaneViewModel>> LookupAsync(string nome)
        {
            throw new NotImplementedException();
        }      
    }
}
