using Domain.GeradorContrato.DTO.ModeloContrato;
using Domain.GeradorContrato.Interface.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace API.GeradorContrato.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelosContratoController : ControllerBase
    {
        private readonly IModeloContratoService _serviceModeloContrato;

        public ModelosContratoController(IModeloContratoService serviceModeloContrato)
        {
            _serviceModeloContrato = serviceModeloContrato;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CriarModeloContratoDTO modeloContrato)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                if (_serviceModeloContrato.CriarModeloContrato(modeloContrato))
                    return Created("Criado com sucesso!", modeloContrato);
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
