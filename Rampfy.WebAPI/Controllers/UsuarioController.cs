using Microsoft.AspNetCore.Mvc;
using Rampfy.WebAPI.Data;
using Rampfy.WebAPI.Models;

namespace Rampfy.WebAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
  public class UsuarioController : ControllerBase
    {
    private readonly DataContext _context;
        public UsuarioController(DataContext context){
            _context = context;
        }

        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Usuarios);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id )
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Id == id);
            if(usuario == null) return BadRequest("Não foi encontrado um Usuário com este Id!");
            return Ok(usuario);
        }

        [HttpPost()]
        public IActionResult Post(Usuario usuario )
        {
            _context.Add(usuario);
            _context.SaveChanges();
            return Ok(usuario);
        }
        

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Id == id);
            if(usuario == null) return BadRequest("Usuário não encontrado!");
            _context.Remove(usuario);
            _context.SaveChanges();
            return Ok();
        }
    }
}