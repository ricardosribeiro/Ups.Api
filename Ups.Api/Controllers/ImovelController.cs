using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ups.Api.ViewModels;

namespace Ups.Api.Controllers
{
    public class ImovelController : MainController
    {
        private readonly IImovelService _imovelService;
        public ImovelController(IImovelService Imovelservice)
        {
            _imovelService = Imovelservice;
        }

        [HttpGet]
        public Task<ActionResult<IEnumerable<ImovelViewModel>>> GetAll()
        {
            
        }


    }
}
