using Microsoft.AspNetCore.Mvc;
using Rampfy.WebAPI.Models;

namespace Rampfy.WebAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
  public class UsuarioController : ControllerBase
    {

        public List<Usuario> Usuarios = new List<Usuario>(){
            new Usuario() {
                Codigo = 1,
                Email = "Edson@mail.com",
                Senha = "testeSenha"
            },
            new Usuario() {
                Codigo = 2,
                Email = "EdsonOutro@mail.com",
                Senha = "testeSenha"
            },
            new Usuario() {
                Codigo = 3,
                Email = "EdsonMaisUm@mail.com",
                Senha = "testeSenha"
            }
        };
        public UsuarioController(){}
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Usuarios);
        }

        [HttpGet("{codigo}")]
        public IActionResult GetById(int codigo )
        {
            var usuario = Usuarios.FirstOrDefault(u => u.Codigo == codigo);
            if(usuario == null) return BadRequest("Não foi encontrado um Usuário com este Código!");
            return Ok(usuario);
        }

        [HttpPost()]
        public IActionResult Post(Usuario usuario )
        {
            return Ok(usuario);
        }

        [HttpDelete("{codigo}")]
        public IActionResult Delete(int codigo)
        {
            return Ok();
        }
    }
}