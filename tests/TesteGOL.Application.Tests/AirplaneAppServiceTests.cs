using NSubstitute;
using System;
using TesteGOL.Application.Cadastros.Interfaces;
using Xunit;

namespace TesteGOL.Application.Tests
{
    public class AirplaneAppServiceTests
    {
        private readonly IAirplaneAppService _airplaneAppService;
        public AirplaneAppServiceTests()
        {
            _airplaneAppService = Substitute.For<IAirplaneAppService>();
        }

        [Fact]
        public async void Listar()
        {
            var r = await _airplaneAppService.ListarAsync(10, 10);
            
        }
    }
}
