namespace ClientesCRUD.Model;

public class Cliente
{
    public int ID {get;set;}
    public Pessoa? novoCliente {get;set;}
    public string? endereço {get;set;}
    public double saldo {get;set;}
}