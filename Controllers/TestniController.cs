using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;
using Logger;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Interfaces;

namespace ERV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestniController : ControllerBase
    {
        private ILogService logService;
        private IUnitOfWork unitOfWork;

        public TestniController(IUnitOfWork _unitOfWork, ILogService _logService)
        {
            this.unitOfWork = _unitOfWork; this.logService = _logService;
        }

        [HttpGet]
        public IEnumerable<Uposlenici> Get()
        {
            logService.Info("Get Got Called!");
            var uposlenici = unitOfWork.Uposlenici.GetAll();
            //return new string[] { "Jedan", "Dva" };
            return uposlenici;
        }
    }
}