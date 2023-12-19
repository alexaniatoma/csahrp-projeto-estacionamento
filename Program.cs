// See https://aka.ms/new-console-template for more information


//Ecoding para UTF8 para exibir acentuação
using System.Globalization;
using estacionamento_desafio_dio.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial;
decimal precoHora;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento STOP!\n" + "Digite o preço inicial: ");


precoInicial = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Agora digite o preço por hora:");
precoHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento stop = new Estacionamento(precoInicial, precoHora);

bool exibirMenu = true;

while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1- Cadastrar veiculo");
    Console.WriteLine("2- Remover veículo");
    Console.WriteLine("3- Lista Veiculos");
    Console.WriteLine("4- Encerrar");

    switch(Console.ReadLine())
    {
            case "1":
            stop.AdicionarVeiculo();
            break;

            case "2":
            stop.RemoverVeiculo();
            break;

            case "3":
            stop.ListarVeiculos();
            break;

            case "4":
            exibirMenu = false;
            break;

            default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();

}

Console.WriteLine("O programa se encerrou");

