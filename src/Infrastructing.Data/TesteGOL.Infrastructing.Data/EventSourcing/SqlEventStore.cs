using Microsoft.EntityFrameworkCore;
using TesteGOL.Domain.Core.Events;
using Newtonsoft.Json;

namespace MiniApps.Imovel.Infra.Data.EventSourcing
{
    public class SqlEventStore : IEventStore
    {
        private readonly IUnitOfWork _unityOfWork;
        private readonly IRepository<StoredEvent> _eventStoreRepository;
        //private readonly Usuario _user;

        public SqlEventStore(IUnitOfWork unitOfWork/*, Usuario user*/)
        {
            _unityOfWork = unitOfWork;
            _eventStoreRepository = _unityOfWork.GetRepository<StoredEvent>();
            //_user = user;
        }

        public void Save<T>(T theEvent) where T : Event
        {
            
            var serializedData = JsonConvert.SerializeObject(theEvent);

            var storedEvent = new StoredEvent(
                theEvent,
                serializedData,
                "System");

            _eventStoreRepository.Insert(storedEvent);
            _unityOfWork.SaveChanges();
            
        }
    }
}