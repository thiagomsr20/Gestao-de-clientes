using Cliente_REST_API.Interface;
using Cliente_REST_API.Model;
using System.Xml.Linq;

namespace Cliente_REST_API.Service
{
    class RegistroClienteService : ICrudService<Cliente>
    {
        static List<Cliente> ListaDeClientesCadastrados = new List<Cliente>();
        static int proximaID = 1;

        public void InsertElement(Cliente newCliente)
        {
            newCliente.ID = proximaID++;
            ListaDeClientesCadastrados.Add(newCliente);
        }

        public Cliente GetElementById(int id) => ListaDeClientesCadastrados.FirstOrDefault(i => i.ID == id);

        public List<Cliente> GetElementList()
        {
            if (ListaDeClientesCadastrados.Count() == 0)
            {
                return null;
            }
            return ListaDeClientesCadastrados;
        }

        public void UpdateElement(int id, Cliente updatedCliente)
        {
            var index = ListaDeClientesCadastrados.FindIndex(cliente => cliente.ID == id);
            if (index == -1) return;

            ListaDeClientesCadastrados[index] = updatedCliente;
        }

        public void DeleteElementById(int id)
        {
            var cliente = GetElementById(id);
            if (cliente is null) return;

            ListaDeClientesCadastrados.Remove(cliente);
        }

    }
}
