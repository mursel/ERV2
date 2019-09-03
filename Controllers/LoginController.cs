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
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILogService logService;
        private IUnitOfWork unitOfWork;

        public LoginController(IUnitOfWork _unitOfWork, ILogService _logService)
        {
            this.unitOfWork = _unitOfWork; this.logService = _logService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(string uname, string upass)
        {
            logService.Info("LoginController:Authenticate!");
            try
            {
                var uposlenik = unitOfWork.Uposlenici.GetByUserAndPass(uname, upass);

                if (uposlenik == null)
                {
                    logService.Err($"Uposlenik nije pronadjen u bazi podataka!");
                    return NotFound();
                }
                else
                {
                    return Ok(uposlenik);
                }
            }
            catch (Exception ex)
            {
                logService.Err($"GRESKA: {ex.Message}");
                return StatusCode(500, "Interna serverska greška!");
            }
        }

    }
}