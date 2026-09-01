

class ContaRepository
{
    private static List<Conta> contas = new List<Conta>();

    public Conta getConta(string CPF)
    {
        foreach(Conta conta in contas)
        {
            if (conta.CPF == CPF)
            {
                return conta;
            }
        }
        return null;
    }

    public void adicionarConta(Conta conta)
    {
        contas.Add(conta);
        foreach(Conta c in contas)
        {
            Console.WriteLine($"{c.CPF} - {c.nome} - {c.saldo} - {c.tipoConta}");
        }
    }

    public bool deletarConta(string CPF)
    {
        Conta conta = getConta(CPF);
        
        if (conta == null)
        {
            return false;
        }

        contas.Remove(conta);
        return true;
    }
}