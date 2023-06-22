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
        var clientes = ServicesHttp.RetornarTodosClientesCadastrados();
        if(clientes is null) return NotFound();
        return clientes;
    }

    [HttpGet("{id}")]
    public ActionResult<Cliente> GetByID(int id)
    {
        var cliente = ServicesHttp.RetornarUmClientePeloID(id);
        if(cliente is null) return NotFound();
        return cliente;
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
        return Ok();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        if(ServicesHttp.RetornarUmClientePeloID(id) is null) return NotFound();

        ServicesHttp.RemoverUmClienteDaLista(id);
        return Ok();
    }

}