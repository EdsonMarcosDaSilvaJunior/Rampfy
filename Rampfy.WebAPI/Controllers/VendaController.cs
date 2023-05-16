using Microsoft.AspNetCore.Mvc;
using Rampfy.WebAPI.Models;

namespace Rampfy.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
  public class VendaController : ControllerBase
    {

        public List<Venda> Vendas = new List<Venda>(){
            new Venda() {
                Id = 1,
                Codigo = 1354235,
                Data = DateTime.Now,
                Valor = 123
            },
            new Venda() {
                Id = 2,
                Codigo = 5467457,
                Data = DateTime.Now,
                Valor = 123534626
            },
            new Venda() {
                Id = 1,
                Codigo = 123535,
                Data = DateTime.Now,
                Valor = 1234123123
            }
        };
        public VendaController(){}

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Vendas);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id )
        {
            var venda = Vendas.FirstOrDefault(v => v.Id == id);
            if(venda == null) return BadRequest("Não foi encontrado uma Venda com este Código!");
            return Ok(venda);
        }

        [HttpPost()]
        public IActionResult Post(Venda venda )
        {
            return Ok(venda);
        }



    }
}