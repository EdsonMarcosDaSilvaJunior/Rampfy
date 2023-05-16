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
                Codigo = 1,
                Data = DateTime.Now,
                Valor = 123
            },
            new Venda() {
                Codigo = 2,
                Data = DateTime.Now,
                Valor = 123534626
            },
            new Venda() {
                Codigo = 3,
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

        [HttpGet("{codigo}")]
        public IActionResult GetById(int codigo )
        {
            var venda = Vendas.FirstOrDefault(v => v.Codigo == codigo);
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