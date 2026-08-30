using System.Runtime.CompilerServices;

namespace meuProjeto.Models;


public class Conta
{
    private double Saldo = 0;
    private string NomeCliente;
    public bool Ativo = true;
    
    // Construtor
    public Conta(double saldo, string cliente)
    {
        Saldo = saldo;
        NomeCliente = cliente;
    }

    public void imprimaOsDadosDoCliente()
    {
        Console.WriteLine($"O nome do cliente eh {NomeCliente} e tem saldo de {Saldo}");
    }

    public double adicioneSaldo(double saldo_de_entrada)
    {
        if (saldo_de_entrada <= 0)
        {
            Console.WriteLine("!!!! Erro: Nao posso adicionar um saldo negativo ou zerado!!!");
        }
        else
        {
           Saldo += saldo_de_entrada; 
        }

        return Saldo;
    }

    public bool debitarSaldo(double valor_a_debitar)
    {
        //early return -- retorno precosse 
        if (valor_a_debitar < 0)
        {
            return false;
        }

        if (valor_a_debitar == 0)
        {
            return false;
        }
        
        // Saldo -= valor_a_debitar;
        Saldo = Saldo - valor_a_debitar;

        return true;
    }

    public void inativarConta()
    {
        Ativo = false;
    }

    public bool aContaEstaAtiva()
    {
        return Ativo;
    }
}



// controller -> service -> repositorio -> domain
// controllet -> servico -> controller                      