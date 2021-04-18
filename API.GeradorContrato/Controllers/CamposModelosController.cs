using Domain.GeradorContrato.DTO.CamposModelos;
using Domain.GeradorContrato.Interface.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace API.GeradorContrato.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CamposModelosController : ControllerBase
    {
        private readonly ICamposModelosService _serviceCamposModelos;

        public CamposModelosController(ICamposModelosService serviceCamposModelos)
        {
            _serviceCamposModelos = serviceCamposModelos;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CriarCamposModelosDTO camposModelos)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                if (_serviceCamposModelos.CriarCamposModelos(camposModelos))
                    return Created("Criado com sucesso!", camposModelos);
                else
                    return BadRequest();
            }
            catch(ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
