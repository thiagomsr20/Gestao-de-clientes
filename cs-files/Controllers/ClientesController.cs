using Microsoft.AspNetCore.Mvc;
using ClientesCRUD.Model;
using ClientesCRUD.Services;

namespace ClientesCRUD.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientesController : ControllerBase
{

    [HttpGet("")]
    public ActionResult<List<Cliente>> GetAll()
    {
        var cliente = ServicesHttp.RetornarTodosClientesCadastrados();
        if(cliente == null) return BadRequest();
        return Ok();
    }

    [HttpGet("{id}")]
    public ActionResult<Cliente> GetByID(int id)
    {
        var cliente = ServicesHttp.RetornarUmClientePeloID(id);
        if(cliente == null) return BadRequest();
        return Ok();
    }

    [HttpPost]
    public ActionResult Post(Cliente cliente)
    {
        ServicesHttp.RegistrarNovoCliente(cliente);
        return Ok();
    }

    [HttpPut("{id}")]
    public ActionResult Put(int id)
    {
        // if (id != pizza.Id) return BadRequest();
           
        // var existingPizza = PizzaService.Get(id);

        // if(existingPizza is null) return NotFound();
    
        // PizzaService.Update(pizza);           
    
        // return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        if(ServicesHttp.RetornarUmClientePeloID(id) == null) return BadRequest();

        ServicesHttp.RemoverUmClienteDaLista(id);
        return Ok();
    }

}
