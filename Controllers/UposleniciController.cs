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
    public class UposleniciController : ControllerBase
    {
        private ILogService logService;
        private IUnitOfWork unitOfWork;

        public UposleniciController(IUnitOfWork _unitOfWork, ILogService _logService)
        {
            this.unitOfWork = _unitOfWork; this.logService = _logService;
        }

        [HttpGet("details/{id}")]
        public IActionResult Get(int id)
        {
            logService.Info("UposleniciController:Get!");
            try
            {
                var uposlenik = unitOfWork.Uposlenici.GetById(id);

                if (uposlenik == null)
                {
                    logService.Err($"Uposlenik sa id: {id} nije pronadjen u bazi podataka!");
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

        [HttpGet]
        public IEnumerable<Uposlenici> GetAll()
        {
            logService.Info("UposleniciController:GetAll!");
            var uposlenici = unitOfWork.Uposlenici.GetAll();
            //return new string[] { "Jedan", "Dva" };
            return uposlenici;
        }

        [HttpGet("bySektor")]
        public IEnumerable<Uposlenici> GetAllBySector(int sektorId)
        {
            logService.Info("UposleniciController:GetAllBySector");
            var uposlenici = unitOfWork.Uposlenici.GetAllBySectorId(sektorId);
            return uposlenici;
        }
    }
}