using Microsoft.AspNetCore.Mvc;
using ClientesCRUD.Model;
using ClientesCRUD.Services;

namespace ClientesCRUD.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientesController : ControllerBase
{

    [HttpGet]
    public ActionResult<List<Cliente>> GetAll()
    {
        var cliente = ServicesHttp.RetornarTodosClientesCadastrados();
        if(cliente == null) return NotFound();
        return Ok();
    }

    [HttpGet("{id}")]
    public ActionResult<Cliente> GetByID(int id)
    {
        var cliente = ServicesHttp.RetornarUmClientePeloID(id);
        if(cliente == null) return NotFound();
        return Ok();
    }

    [HttpPost]
    public ActionResult Post(Cliente cliente)
    {
        ServicesHttp.RegistrarNovoCliente(cliente);
        return Ok();
    }

    [HttpPut("{id}")]
    public ActionResult Put(int id, Cliente cliente)
    {
        if (id != cliente.ID) return BadRequest();

        var clienteExistente = ServicesHttp.RetornarUmClientePeloID(id);
        if(clienteExistente is null) return NotFound();

        ServicesHttp.AtualizarDadosDeUmCliente(id, cliente);           
        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        if(ServicesHttp.RetornarUmClientePeloID(id) == null) return BadRequest();

        ServicesHttp.RemoverUmClienteDaLista(id);
        return Ok();
    }

}