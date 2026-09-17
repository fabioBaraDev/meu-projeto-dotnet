

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

    public bool atualizarNome(string CPF, string novoNome)
    {
        Conta conta = getConta(CPF);

        if (conta == null)
        {
            return false;
        }

        conta.atualizarNome(novoNome);
        return true;
    }

    public bool atualizarSaldo(string CPF, double novoSaldo)
    {
        Conta conta = getConta(CPF);

        if (conta == null)
        {
            return false;
        }

        conta.atualizarSaldo(novoSaldo);
        return true;
    }

    public bool atualizarTipoConta(string CPF, TipoConta novoTipoConta)
    {
        Conta conta = getConta(CPF);

        if (conta == null)
        {
            return false;
        }

        conta.atualizarTipoConta(novoTipoConta);
        return true;
    }
}