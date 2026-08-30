class Conta
{
    public string nome {get; private set;} 
    public string CPF {get; private set;} 
    public double saldo {get; private set;} 
    public TipoConta tipoConta {get; private set;} 
    public Conta(
        string nome, 
        string CPF, 
        TipoConta tipoConta, 
        double saldo = 0)
    {
        this.nome = nome;
        this.CPF = CPF;
        this.saldo = saldo;
        this.tipoConta = tipoConta;
    }
}

public enum TipoConta
{
    Pobrinho,
    ClassMedia,
    Rico
}