using ClientesCRUD.Model;

namespace ClientesCRUD.Services;

public class ServicesHttp
{
    static List<Cliente> ListaDeClientesCadastrados = new List<Cliente>();
    static int proximaID = 1;

    // Get
    public static List<Cliente>? RetornarTodosClientesCadastrados()
    {
        if(ListaDeClientesCadastrados.Count() == 0)
        {
            return null;
        }
        return ListaDeClientesCadastrados;
    }

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
        if(cliente is null) return;

        ListaDeClientesCadastrados.Remove(cliente);
    }

    // Put {id}
    public static void AtualizarDadosDeUmCliente(int id, Cliente clienteAtualizado)
    {
        var index = ListaDeClientesCadastrados.FindIndex(cliente => cliente.ID == id);
        if(index == -1) return;

        ListaDeClientesCadastrados[index] = clienteAtualizado;
    }

}