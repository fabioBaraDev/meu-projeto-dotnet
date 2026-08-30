using System.Security.Cryptography.X509Certificates;
using meuProjeto.Models;


Conta conta_2 = new Conta(1000, "Rosangelo");
conta_2.adicioneSaldo(5);

// bool retornou_de_debitar = conta_2.debitarSaldo(5);

// if (retornou_de_debitar == true)
// {
//     Console.WriteLine("Deu bom no debito");
// }

// if (retornou_de_debitar == false)
// {
//     Console.WriteLine("Deu ruim no debito");
// }

// conta_2.imprimaOsDadosDoCliente();

// bool variavel = conta_2.aContaEstaAtiva();

// x = (1 * 2) + 3
//if (conta_2.aContaEstaAtiva() == true)
//if (false == true)
//resultado = falso

// if true or false

//  2==1 = false       

conta_2.setAtivo(true);

if (conta_2.getAtivo())
{
    Console.WriteLine("A conta esta ativa");
}
else
{
    Console.WriteLine("A conta esta inativa");
}