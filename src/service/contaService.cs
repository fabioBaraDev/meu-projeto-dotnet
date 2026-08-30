// controller -> service -> repository (domain)


class ContaService
{
    ContaRepository repository = new ContaRepository();

    public Conta getConta(string CPF)
    {
        Conta conta = this.repository.getConta(CPF);
        return conta;
    }

    public void adicionarConta(
        string nome, 
        string CPF, 
        double saldo, 
        TipoConta tipoConta)
    {
        Conta conta = new Conta(nome, CPF, tipoConta, saldo);
        this.repository.adicionarConta(conta);

        Console.WriteLine($"Inseriu {conta.nome} com sucesso");
    } 

    //implementar consultarCliente retornar um Cliente ou NULL
    //usar o respositorio.getConta para procurar o cliente
    
}