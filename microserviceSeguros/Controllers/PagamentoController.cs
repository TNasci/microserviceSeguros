using microserviceSeguros.Application.DTOs;
using microserviceSeguros.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace microserviceSeguros.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PagamentoController : Controller
    {
        private readonly IApplicationServicePagamento applicationServicePagamento;

        public PagamentoController(IApplicationServicePagamento applicationServicePagamento)
        {
            this.applicationServicePagamento = applicationServicePagamento;
        }

        [HttpPost]
        public ActionResult Post([FromBody] PagamentoDTO pagamentoDTO)
        {
            try
            {
                if (pagamentoDTO == null)
                    return NotFound();

                return Ok(this.applicationServicePagamento.CacularJuros(pagamentoDTO));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
