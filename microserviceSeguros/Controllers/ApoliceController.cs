using microserviceSeguros.Application.DTOs;
using microserviceSeguros.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace microserviceSeguros.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApoliceController : ControllerBase
    {
        private readonly IApplicationServiceApolice applicationServiceApolice;

        public ApoliceController(IApplicationServiceApolice applicationServiceApolice)
        {
            this.applicationServiceApolice = applicationServiceApolice;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(this.applicationServiceApolice.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(this.applicationServiceApolice.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ApoliceDTO apoliceDTO)
        {
            try
            {
                if (apoliceDTO == null)
                    return NotFound();

                this.applicationServiceApolice.Add(apoliceDTO);
                return Ok("Apolice Cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ApoliceDTO apoliceDTO)
        {
            try
            {
                if (apoliceDTO == null)
                    return NotFound();

                this.applicationServiceApolice.Update(apoliceDTO);
                return Ok("Apolice Atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<string> Delete([FromBody] ApoliceDTO apoliceDTO)
        {
            try
            {
                if (apoliceDTO == null)
                    return NotFound();

                this.applicationServiceApolice.Delete(apoliceDTO);
                return Ok("Apolice Excluida com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
