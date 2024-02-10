using Cliente_REST_API.Interface;
using Cliente_REST_API.Model;
using Microsoft.AspNetCore.Mvc;
using Cliente_REST_API.Service;
using Cliente_REST_API.Model;

namespace ClienteAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {

        private ICrudService<Cliente> RegistroClienteService = new RegistroClienteService();

        [HttpGet(Name = "GetAll")]
        public ActionResult<List<Cliente>> GetAll()
        {
            var clientes = RegistroClienteService.GetElementList();
            if (clientes is null) return NotFound();
            return clientes;
        }

        [HttpGet("{id}")]
        public ActionResult<Cliente> GetByID(int id)
        {
            var cliente = RegistroClienteService.GetElementById(id);
            if (cliente is null) return NotFound();
            return cliente;
        }

        [HttpPost]
        public ActionResult Post(Cliente cliente)
        {
            RegistroClienteService.InsertElement(cliente);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, Cliente cliente)
        {
            if (id != cliente.ID) return BadRequest();

            var clienteExistente = RegistroClienteService.GetElementById(id);
            if (clienteExistente is null) return NotFound();

            RegistroClienteService.UpdateElement(id, cliente);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (RegistroClienteService.GetElementById(id) is null) return NotFound();

            RegistroClienteService.DeleteElementById(id);
            return Ok();
        }
    }
}

