using Microsoft.AspNetCore.Mvc;
using Rampfy.WebAPI.Data;
using Rampfy.WebAPI.Models;

namespace Rampfy.WebAPI.Controllers
{
  [ApiController]
    [Route("api/[controller]")]
public class VendaController : ControllerBase
    {
    private readonly DataContext _context;
        public VendaController(DataContext context){
            _context = context;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Vendas);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var venda = _context.Vendas.Find(id);
            if(venda == null) return BadRequest("Não foi encontrado uma Venda com este Id!");
            return Ok(venda);
        }

        [HttpPost()]
        public IActionResult Post(Venda venda)
        {
            _context.Add(venda);
            _context.SaveChanges();
            return Ok(venda);
        }



    }
}