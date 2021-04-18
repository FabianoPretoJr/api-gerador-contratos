using Domain.GeradorContrato.DTO.Usuario;
using Domain.GeradorContrato.Interface.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace API.GeradorContrato.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _serviceUsuario;

        public UsuarioController(IUsuarioService serviceUsuario)
        {
            _serviceUsuario = serviceUsuario;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CadastrarUsuarioDTO usuario)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                if (_serviceUsuario.CadastrarUsuario(usuario))
                    return Created("Criado com sucesso!", usuario);
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
