namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
{
    Console.WriteLine("Digite a placa do veículo para remover:");
    string placa = Console.ReadLine();

    // Verifica se o veículo existe
    if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
    {
        Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
        int horas = int.Parse(Console.ReadLine());
        decimal valorTotal = precoInicial + (precoPorHora * horas);

        // Remover a placa da lista
        veiculos.RemoveAll(x => x.ToUpper() == placa.ToUpper());

        Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
    }
    else
    {
        Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
    }
}

       public void ListarVeiculos()
{
    if (veiculos.Any())
    {
        Console.WriteLine("Os veículos estacionados são:");
        for (int i = 0; i < veiculos.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {veiculos[i]}");
        }

        Console.WriteLine("Gostaria de remover algum veículo? (S/N)");
        string resposta = Console.ReadLine();

        if (resposta.ToUpper() == "S")
        {
            Console.WriteLine("Digite o número do veículo que deseja remover:");
            if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 1 && indice <= veiculos.Count)
            {
                string placaRemovida = veiculos[indice - 1];

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + (precoPorHora * horas);

                veiculos.RemoveAt(indice - 1);

                Console.WriteLine($"O veículo {placaRemovida} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Número inválido.");
            }
        }
    }
    else
    {
        Console.WriteLine("Não há veículos estacionados.");
    }
}


    }
}   