using Domain.GeradorContrato.DTO.ValoresCampos;
using Domain.GeradorContrato.Interface.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace API.GeradorContrato.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValoresCamposController : ControllerBase
    {
        private readonly IValoresCamposService _serviceValoresCampos;

        public ValoresCamposController(IValoresCamposService serviceValoresCampos)
        {
            _serviceValoresCampos = serviceValoresCampos;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CriarValoresCamposDTO valoresCampos)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                if (_serviceValoresCampos.CriarValoresCampos(valoresCampos))
                    return Created("Criado com sucesso!", valoresCampos);
                else
                    return BadRequest();
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
