using ConsoleApp_PWEB;
using ConsoleApp_PWEB.Heranca;

Endereco endereco = new Endereco("Rua Mario Miziara", "91", "Sobral", "15906304", "Taquaritinga", "SP");

Cliente c1 = new Cliente(1, "Gabriele", "991340447", endereco);
Cliente c2 = new Cliente(2, "Gabriela", "991340447", endereco);
Cliente c3 = new Cliente(3, "Ryan", "991340447", endereco);
Cliente c4 = new Cliente(4, "Fernanda", "991340447", endereco);
Cliente c5 = new Cliente(5, "Giovanni", "991340447", endereco);

// 1 - Imprima na tela todos os clientes desse contexto;
Console.WriteLine("\n\nClientes: ");
List<Cliente> clientes = new(new Cliente[] { c1, c2, c3, c4, c5 });
foreach (Cliente cliente in clientes)
{
    Console.WriteLine(cliente.getDados());
}

// 2 - Crie uma lista com 560 produtos
Console.WriteLine("\n\nProdutos: ");
List<Produto> produtos = new List<Produto>();
for (int i = 1; i <= 560; i++)
{
    Produto prod = new Produto(i, i * 5, "Item " + i);
    produtos.Add(prod);
    Console.WriteLine(prod.getDados());
}

// 3 - Crie uma lista que aceite qualquer tipo de veiculo
Console.WriteLine("\n\nVeiculos: ");
Carro jetta = new Carro();
jetta.temMotor = true;
jetta.numeroPortas = 4;
jetta.numeroAssentos = 5;
jetta.fabricante = "Volkswagen";
jetta.cintoSeguranca = true;
jetta.arCondicionado = true;
jetta.velocidadeMaximaEmKmH = 210;

Carro m5 = new Carro();
m5.temMotor = true;
m5.numeroPortas = 4;
m5.numeroAssentos = 5;
m5.fabricante = "BMW";
m5.cintoSeguranca = true;
m5.arCondicionado = true;
m5.velocidadeMaximaEmKmH = 250;

Bike first = new Bike();
first.temMotor = false;
first.numeroPortas = 0;
first.numeroAssentos = 1;
first.qtdMarchas = 11;

Bike caloi = new Bike();
caloi.temMotor = false;
caloi.numeroPortas = 0;
caloi.numeroAssentos = 1;
caloi.qtdMarchas = 21;

List<Veiculo> veiculos = new(new Veiculo[] { jetta, m5, first, caloi });
foreach (Veiculo veiculo in veiculos)
{
    Console.WriteLine(veiculo.ExibirDados());
}
