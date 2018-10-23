using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using TesteGOL.Domain.Core.Bus;
using TesteGOL.Domain.Core.Notifications;
using TesteGOL.Infrastructing.Data.Context;
using TesteGOL.Shared.Bus;


namespace TesteGOL.Shared.AspNetCore.Bootstrapper
{
    public class AspNetCoreInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // ASP.NET HttpContext dependency
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Domain Bus (Mediator)
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            // ASP.NET Authorization Polices
            //services.AddSingleton<IAuthorizationHandler, ClaimsRequirementHandler>(); ;

            // Application
            //services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));
            //services.AddScoped<IEstadoAppService, EstadoAppService>();

            // Domain - Events
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
            //services.AddScoped<INotificationHandler<CustomerRegisteredEvent>, CustomerEventHandler>();
            //services.AddScoped<INotificationHandler<CustomerUpdatedEvent>, CustomerEventHandler>();
            //services.AddScoped<INotificationHandler<CustomerRemovedEvent>, CustomerEventHandler>();

            // Domain - Commands
            //services.AddScoped<INotificationHandler<RegisterNewCustomerCommand>, CustomerCommandHandler>();
            //services.AddScoped<INotificationHandler<UpdateCustomerCommand>, CustomerCommandHandler>();
            //services.AddScoped<INotificationHandler<RemoveCustomerCommand>, CustomerCommandHandler>();

            // Infra - Data
            //services.AddScoped<ICustomerRepository, CustomerRepository>();
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<GolContext>()
                .AddUnitOfWork<GolContext>();

            // Infra - Data EventSourcing
            //services.AddScoped<IEventStoreRepository, EventStoreSQLRepository>();
            //services.AddScoped<IEventStore, SqlEventStore>();
            //services.AddScoped<EventStoreSQLContext>();

            // Infra - Identity Services
            //services.AddTransient<IEmailSender, AuthEmailMessageSender>();
            //services.AddTransient<ISmsSender, AuthSMSMessageSender>();

            // Infra - Identity
            //services.AddScoped<IUser, AspNetUser>();
        }
    }
}
