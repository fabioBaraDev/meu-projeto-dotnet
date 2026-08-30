

public class CommandLineController
{

    ContaService contaService = new ContaService();
    
    public bool adicionarConta(string nome, string CPF, string saldo, string tipoConta)
    {
        //precisa validar o CPF se CPF invalido retornar erro 
        //https://www.4devs.com.br/gerador_de_cpf
        // criar uma funcao que quebre a string em pontos e traco 
        // exemplo 236.491.900-28
        // [236, 491, 900, 28]
        // foreach ... e cada um desses caras tem que ser inteiro se nao for, tem que imprir erro e voltar pro inicio do programa

        bool saldo_is_success = Double.TryParse(saldo, out double saldoConvertido);
        bool tipo_conta_is_success = Enum.TryParse(tipoConta, out TipoConta tipoContaConvertido);

        if (saldo_is_success && tipo_conta_is_success)
        {
            contaService.adicionarConta(
                nome, 
                CPF, 
                saldoConvertido, 
                tipoContaConvertido
            );
            return true;
        }
        return false;
    }
    public void consultarCliente()
    {
        //imprimir o cliente se houver se nao imprimir cliente nao exite 
    }

    public void deletarCliente()
    {
        
    }

    public void atualizarCliente()
    {
        
    }


}