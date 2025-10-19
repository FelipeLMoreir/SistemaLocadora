using SistemaLocadora;

int opcao;

do
{
    Console.WriteLine("Digite qual opção dseja:\n1 - Cadastrar Veículo" +
        "\n2 - Cadastrar Cliente\n3 - Registro e valor da locação" +
        "\n4 - Listar veículos, clientes e locações");
    opcao = int.Parse(Console.ReadLine()!);
    switch (opcao)
    {
        case 1:
            break;
        case 2:
            break;
        case 3:
            break;
        default:
            break;
    }
}
while (opcao != 0);