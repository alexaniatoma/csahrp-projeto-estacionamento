using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace estacionamento_desafio_dio.Models
{
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoHora;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }

        public void AdicionarVeiculo()
        {
            DateTime dataAtual = DateTime.Now;

            Console.WriteLine($"Data e Hora da entrada do veículo: {dataAtual}");
            Console.WriteLine("Digite a placa do veículo para estacionar");
            veiculos.Add(Console.ReadLine());
        }   
        public void RemoverVeiculo()
        {
            for(int count = 0; count < veiculos.Count; count++){
              
                Console.WriteLine("Digite a placa do veículo para remover");
                  string placa = Console.ReadLine();
             
                if(veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    
                    Console.WriteLine("Digite a quantidade de horas que o veículos permaneceu estacionado");

                    int horas = Convert.ToInt32(Console.ReadLine());
                    decimal valorTotal = precoInicial + (precoHora * (horas - 1));

                    veiculos.Remove(placa);
                    Console.WriteLine($"O veiculo {placa} foi removido e o preço total foi de: {valorTotal:C}");

                }
                else{
                    Console.WriteLine("Desculpe, esse veículo não está estacionando aqui. Confira se digitou a placa corretamente");
                }
            }

            }

        public void ListarVeiculos()
        {
         
            for(int count = 0; count < veiculos.Count; count++)
            {
                
                if(veiculos.Any())
                {
                    Console.WriteLine($"Nº {count + 1} Os veiculos estacionados são: {veiculos[count]}" );
                }
                else
                {
                    Console.WriteLine("Não há veículos estacionados");

                }
            }
        }
            
    }
}
