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
                Id = 1,
                Codigo = 123,
                Email = "Edson@mail.com",
                Senha = "testeSenha"
            },
            new Usuario() {
                Id = 2,
                Codigo = 456,
                Email = "EdsonOutro@mail.com",
                Senha = "testeSenha"
            },
            new Usuario() {
                Id = 3,
                Codigo = 789,
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

        [HttpGet("{id}")]
        public IActionResult GetById(int id )
        {
            var usuario = Usuarios.FirstOrDefault(u => u.Id == id);
            if(usuario == null) return BadRequest("Não foi encontrado um Usuário com este Código!");
            return Ok(usuario);
        }

        [HttpPost()]
        public IActionResult Post(Usuario usuario )
        {
            return Ok(usuario);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}