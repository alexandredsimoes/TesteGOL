using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteGOL.Application.Cadastros.Interfaces;
using TesteGOL.Application.Cadastros.ViewModels;

namespace TesteGol.Presentation.Web.Controllers
{
    [Route("api/[controller]")]
    public class AirplaneController : Controller
    {
        private readonly IAirplaneAppService _airplaneAppService;

        public AirplaneController(IAirplaneAppService airplaneAppService)
        {
            _airplaneAppService = airplaneAppService;
        }

        [HttpGet]
        public async Task<IEnumerable<AirplaneViewModel>> Get()
        {
            var result = await _airplaneAppService.ListarAsync(0,10);
            return result.Items;
        }

        [HttpGet]
        [Route("{Id}")]
        public async Task<AirplaneViewModel> Get(string Id)
        {
            var result = await _airplaneAppService.SelecionarAsync(Guid.Parse(Id));
            return result;
        }

        [HttpPost]
        [Route("CreateAirplane")]
        public async Task<int> Post([FromForm]string airplane)
        {
            var obj = JsonConvert.DeserializeObject<AirplaneViewModel>(airplane);
            var result = await _airplaneAppService.Salvar(obj);
            return result;
        }

        [HttpPut]        
        public async Task<int> Put([FromForm]string airplane)
        {
            var dateTimeConverter = new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" };
            var obj = JsonConvert.DeserializeObject<AirplaneViewModel>(airplane, dateTimeConverter);
            var result = await _airplaneAppService.Salvar(obj);
            return result;
        }

        [HttpDelete]
        [Route("{Id}")]
        public IActionResult Delete(string Id)
        {
            _airplaneAppService.Remover(Guid.Parse(Id));
            return Ok();
        }
    }
}
