using System.Runtime.InteropServices;

namespace meuProjeto.Main;

class Program
{
    static void Main(string[] args)
    {
        while(true){
            CommandLineController commandLineController = new CommandLineController();

            imprimirCabecalho();

            Console.Write("Digite o numero da sua operacao: ");
            string operacao = Console.ReadLine();

            switch (operacao)
            {
                case "1":
                    Console.WriteLine("Você escolheu cadastrar.");
                    {
                    Console.Write("Digite o nome do cliente: ");
                    string nome = Console.ReadLine();

                    Console.Write("Digite o CPF do cliente: ");
                    string CPF = Console.ReadLine();

                    Console.Write("Digite o saldo do cliente: ");
                    string saldo = Console.ReadLine();

                    Console.Write("Digite o tipo da conta do cliente: ");
                    string tipoConta = Console.ReadLine();

                    bool resultado = commandLineController.adicionarConta(nome, CPF, saldo, tipoConta);

                    if (resultado)
                    {
                        Console.WriteLine("Usuario Inserido com sucesso");
                    }
                    else
                    {
                        Console.WriteLine("Deu erro ao inserir usuario");
                    }

                    break;
                    }
                case "2":
                    Console.WriteLine("Você escolheu consultar.");
                    {
                    Console.Write("Digite o CPF do cliente que deseja consultar: ");
                    string CPF = Console.ReadLine();

                    commandLineController.consultarCliente(CPF);

                    break;
                    }

                case "3":
                    Console.WriteLine("Você escolheu excluir.");
                    {
                        Console.WriteLine("Digite o CPF do cliente que deseja excluir: ");
                        string CPF = Console.ReadLine();

                        commandLineController.deletarCliente(CPF);
                    break;
                    }
                
                // ao inves de se atualizar qualquer coisa
                // cria um case so para atualizar nome ou saldo ou tipoconta
                case "4":
                    Console.WriteLine("Você escolheu atualizar.");
                    commandLineController.atualizarCliente();
                    break;
                
                case "5":
                    Console.WriteLine("Adios");
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
    private static void imprimirCabecalho()
    {
        Console.WriteLine("***************");
        Console.WriteLine("");
        Console.WriteLine(" --Sistema Bancario-- ");
        Console.WriteLine("");
        Console.WriteLine("Opcoes: ");
        Console.WriteLine("1 - Cadastrar cliente");
        Console.WriteLine("2 - Consultar cliente");
        Console.WriteLine("3 - Excluir cliente");
        Console.WriteLine("4 - Atualizar cliente");
        Console.WriteLine("5 - Sair do sistema");
        Console.WriteLine("");
        Console.WriteLine("***************");
        Console.WriteLine("");
    }
}

