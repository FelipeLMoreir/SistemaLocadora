using SistemaLocadora;

int opcao;
string modelo;
List<Veiculo> veiculos = new List<Veiculo>();
List<Cliente> clientes = new List<Cliente>();
List<Locacao> locacoes = new List<Locacao>();

void CadastrarVeiculo()
{
    Console.WriteLine("\n1 - Carro | 2 - Moto | 3 - Caminhão");
    Console.Write("Escolha o tipo: ");
    int tipo = int.Parse(Console.ReadLine()!);
    Console.Write("Modelo: ");
    string modelo = Console.ReadLine()!;
    Console.Write("Placa: ");
    string placa = Console.ReadLine()!;
    Console.Write("Preço da diária: ");
    double preco = double.Parse(Console.ReadLine()!);
    Veiculo v = null!;
    switch (tipo)
    {
        case 1:
            Console.Write("Número de portas: ");
            int portas = int.Parse(Console.ReadLine()!);
            v = new Carro(modelo, placa, preco, portas);
            break;
        case 2:
            Console.Write("Cilindradas: ");
            int cilindradas = int.Parse(Console.ReadLine()!);
            v = new Moto(modelo, placa, preco, cilindradas);
            break;
        case 3:
            Console.Write("Capacidade de carga (toneladas): ");
            double carga = double.Parse(Console.ReadLine()!);
            v = new Caminhao(modelo, placa, preco, carga);
            break;
        default:
            Console.WriteLine("Tipo inválido!");
            return;
    }
}
void CadastrarCliente()
{
    Cliente cliente = new Cliente();
    Console.Write("Nome do cliente: ");
    string nome = Console.ReadLine()!;
    Console.Write("CPF: ");
    string cpf = Console.ReadLine()!;
    clientes.Add(new Cliente(nome, cpf));
    Console.WriteLine("Cliente cadastrado!");
}
void ListarVeiculo()
{
    Console.WriteLine("VEÍCULOS:");
    if (veiculos.Count == 0)
    {
        Console.WriteLine("Nenhum veículo cadastrado.");
        return;
    }
    foreach (var v in veiculos)
        v.ExibirInformacoes();
}
void ListarCliente()
{
    Console.WriteLine("CLIENTES:");
    if (clientes.Count == 0)
    {
        Console.WriteLine("Nenhum cliente cadastrado.");
        return;
    }
    foreach (var c in clientes)
        c.ExibirInformacoes();
}
void RegistrarLocacao()
{
    if (clientes.Count == 0 || veiculos.Count == 0)
    {
        Console.WriteLine("É necessário ter clientes e veículos cadastrados!");
        return;
    }
    Console.WriteLine("\n--- Registrar Locação ---");
    Console.WriteLine("Escolha o cliente:");
    for (int i = 0; i < clientes.Count; i++)
    {
        Console.WriteLine($"{i + 1} - {clientes[i]}");

    }
    int clienteIndex = int.Parse(Console.ReadLine()!) - 1;
    Console.WriteLine("Escolha o veículo:");
    for (int i = 0; i < veiculos.Count; i++)
    {
        Console.WriteLine($"{i + 1} - {veiculos[i]}");
    }
    int veiculoIndex = int.Parse(Console.ReadLine()!) - 1;
    Console.Write("Quantidade de dias: ");
    int dias = int.Parse(Console.ReadLine()!);
    Locacao loc = new Locacao(clientes[clienteIndex], veiculos[veiculoIndex], dias);
    locacoes.Add(loc);
    Console.WriteLine(":marca_de_verificação_branca: Locação registrada com sucesso!");
    Console.WriteLine($"Valor total: R${loc.CalcularValorTotal():F2}");
}
void ListarLocacoes()
{
    Console.WriteLine("LOCAÇÕES:");
    if (locacoes.Count == 0)
    {
        Console.WriteLine("Nenhuma locação registrada.");
        return;
    }
    foreach (var loc in locacoes)
    {
        loc.ExibirDetalhes();
    }
}
Veiculo BuscarVeiculo(string modelo, string placa)
{
    return veiculos.Find(v => v.Modelo.Equals(modelo,
        StringComparison.OrdinalIgnoreCase) && v.Placa.Equals(placa,
        StringComparison.OrdinalIgnoreCase))!;
}
void BuscarVeiculoMenu()
{
    Console.WriteLine("Digite o modelo: ");
    modelo = Console.ReadLine()!;

    Veiculo v = null;

    Console.WriteLine("Digite a placa: ");
    string placa = Console.ReadLine()!;
    v = BuscarVeiculo(modelo, placa);

    if (v != null)
    {
        v.ExibirInformacoes();
    }
}

do
{
    Console.WriteLine("Digite qual opção dseja:\n1 - Cadastrar Veículo" +
        "\n2 - Cadastrar Cliente\n3 - Listas Veículos\n4 - Listar Cliente" +
        "\n5 - Registrar Locação\n6 - Listar Locações\n7 - Buscar Veículo por modelo\n" +
        "0 - Sair");
    opcao = int.Parse(Console.ReadLine()!);
    switch (opcao)
    {
        case 1:
            CadastrarVeiculo();
            break;
        case 2:
            CadastrarCliente();
            break;
        case 3:
            ListarVeiculo();
            break;
        case 4:
            ListarCliente();
            break;
        case 5:
            RegistrarLocacao();
            break;
        case 6:
            ListarLocacoes();
            break;
        case 7:
            BuscarVeiculoMenu();
            break;
        default:
            break;
    }
}
while (opcao != 0);
