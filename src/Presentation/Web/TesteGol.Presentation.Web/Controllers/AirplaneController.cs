using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteGOL.Application.Cadastros.Interfaces;

namespace TesteGol.Presentation.Web.Controllers
{
    public class AirplaneController : Controller
    {
        private readonly IAirplaneAppService _airplaneAppService;

        public AirplaneController(IAirplaneAppService airplaneAppService)
        {
            _airplaneAppService = airplaneAppService;
        }   


    }
}
