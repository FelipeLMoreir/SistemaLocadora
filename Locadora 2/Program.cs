using Locadora_2.Abstracts;
using Locadora_2.Entities;
using Locadora_2.Models;
using System.Windows.Markup;

RentalCompany rentalCompany = new RentalCompany();

List<string> mainOptions = new List<string>()
{
    "Menu Clientes",
    "Menu Veículos",
    "Menu Locações",
    "Sair"
};

List<string> customerOptions = new List<string>()
{
    "Cadastrar Cliente",
    "Listar Clientes",
    "Atualizar Cliente",
    "Remover Cliente",
    "Voltar ao Menu Principal"
};

List<string> vehicleOptions = new List<string>()
{
    "Cadastrar Veículo",
    "Listar Veículos",
    "Atualizar Veículo",
    "Remover Veículo",
    "Voltar ao Menu Principal"
};

List<string> rentalOptions = new List<string>()
{
    "Registrar Locação",
    "Listar Locações",
    "Atualizar Locação",
    "Remover Locação",
    "Voltar ao Menu Principal"
};

void CreateCustomer()
{
    Console.WriteLine("Informe o nome do cliente:");
    string name = Console.ReadLine() ?? "";
    Console.WriteLine("Informe a data de nascimento do cliente:");
    DateOnly birthDate = DateOnly.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Informe o email do cliente:");
    string email = Console.ReadLine() ?? "";
    Console.WriteLine("Informe o logradouro do cliente: ");
    string street = Console.ReadLine() ?? "";
    Console.WriteLine("Informe o número do endereço do cliente: ");
    string number = Console.ReadLine() ?? "";
    Console.WriteLine("Informe o complemento do endereço do cliente: ");
    string complement = Console.ReadLine() ?? "";
    Console.WriteLine("Informe o bairro do cliente: ");
    string neighborhood = Console.ReadLine() ?? "";
    Console.WriteLine("Informe a cidade do cliente: ");
    string city = Console.ReadLine() ?? "";
    Console.WriteLine("Informe o estado do cliente: ");
    string state = Console.ReadLine() ?? "";
    Console.WriteLine("Informe o CEP do cliente: ");
    string zipCode = Console.ReadLine() ?? "";

    var contact = new Contact(email, null);
    var address = new Address(street, int.Parse(number), neighborhood, zipCode, 
        complement, city, state, "BR");
    Console.WriteLine("Qual tipo de cliente está cadastrando? (1: PF/ 2: PJ)");
    int customerType = int.Parse(Console.ReadLine() ?? "1");
    if (customerType == 1)
    {
        Console.WriteLine("Informe o numero da CNH");
        string cnh = Console.ReadLine() ?? "";
        Console.WriteLine("Digite o número do CPF");
        string cpf = Console.ReadLine() ?? "";
        var customer = new CustomerPF(name, birthDate, contact, address, cnh, cpf);
        rentalCompany.Customers.Add(customer);
    }
    else
    {
        Console.WriteLine("Digite o CNPJ da empresa: ");
        string cnpj = Console.ReadLine() ?? "";
        var customer = new CustomerPJ(name, birthDate, contact, address, cnpj);
        rentalCompany.Customers.Add(customer);
    }
}

Person FindCustomerByName(string name)
{
    return rentalCompany.Customers.Find(c => c.getName() == name);
}

void DeleteCustomer()
{
    Console.WriteLine("Digite o nome do cliente que deseja remvoer:");
    string name = Console.ReadLine() ?? "";
    var customer = FindCustomerByName(name);
    if (customer is not null)
    {
        rentalCompany.Customers.Remove(customer);
        Console.WriteLine("Cliente removido");
    }
    else
    {
        Console.WriteLine("Cliente não encontrado");
    }
}

void ListCustomers()
{
    Console.WriteLine("=== Lista de Clientes ===");
    foreach (var customer in rentalCompany.Customers)
    {
        Console.WriteLine(customer);
        //Console.WriteLine(customer.ToString());
    }
}

Person? UpdatePhone()
{
    Console.WriteLine("Digite o nome do cliente a ser atualizado: ");
    string name = Console.ReadLine() ?? "";
    var customer = FindCustomerByName(name);
    if (customer is not null)
    {
        Console.WriteLine("Digite o telefone do cliente: ");
        string phone = Console.ReadLine() ?? "";
        customer.setContactPhone(phone);
        Console.WriteLine("Telefone atualizado");
    }
    else
    {
        Console.WriteLine("Cliente não encontrado");
    }
        return customer;
}

void CustomerMenu(int op)
{
    switch (op)
    {
        case 1:
            CreateCustomer();
            break;
        case 2:
            ListCustomers();
            break;
        case 3:
            Console.WriteLine(UpdatePhone());
            break;
        case 4:
            DeleteCustomer();
            break;
        case 5:
            break;
        default:
            break;
    }
}

do
{
    int mainChoice = Menu.Display("=== Menu Principal ===", mainOptions);

    switch (mainChoice)
    {
        case 1:
            int customerChoice = Menu.Display("=== Menu Clientes ===", customerOptions);
            CustomerMenu(customerChoice);
            break;
        case 2:
            int vehicleChoice = Menu.Display("=== Menu Veículos ===", vehicleOptions);
            break;
        case 3:
            int rentalChoice = Menu.Display("=== Menu Locações ====", rentalOptions);
            break;
        case 4:
            Console.WriteLine("Saindo");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}
while ( true );