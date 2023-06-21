using ClientesCRUD.Model;

namespace ClientesCRUD.Services;

public class ServicesHttp
{
    public static List<Cliente> ListaDeClientesCadastrados = new List<Cliente>();
    public static int proximaID = 0;

    // Get
    public static List<Cliente> RetornarTodosClientesCadastrados() => ListaDeClientesCadastrados;

    // Get {id}
    public static Cliente? RetornarUmClientePeloID(int id) => ListaDeClientesCadastrados.FirstOrDefault(i => i.ID == id);

    // Post
    public static void RegistrarNovoCliente(Cliente novoCliente)
    {
        novoCliente.ID = proximaID++;
        ListaDeClientesCadastrados.Add(novoCliente);
    }

    // Delete
    public static void RemoverUmClienteDaLista(int id)
    {
        var cliente = RetornarUmClientePeloID(id);
        if(cliente == null) return;

        ListaDeClientesCadastrados.Remove(cliente);
    }

    // Put {id}
    public static void AtualizarDadosDeUmCliente(int id, Cliente clienteAtualizado)
    {
        
    }

}