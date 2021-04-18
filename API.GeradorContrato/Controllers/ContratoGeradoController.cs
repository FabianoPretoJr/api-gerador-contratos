using Domain.GeradorContrato.DTO.ContratoGerado;
using Domain.GeradorContrato.Interface.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace API.GeradorContrato.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContratoGeradoController : ControllerBase
    {
        private readonly IContratoGeradoService _serviceContratoGerado;

        public ContratoGeradoController(IContratoGeradoService serviceContratoGerado)
        {
            _serviceContratoGerado = serviceContratoGerado;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CriarContratoGeradoDTO contratoGerado)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                if (_serviceContratoGerado.CriarContratoGerado(contratoGerado))
                    return Created("Criado com sucesso!", contratoGerado);
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
