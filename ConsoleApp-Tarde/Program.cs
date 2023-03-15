using ConsoleApp_Tarde;
using ConsoleApp_Tarde.Heranca;

Produto p1 = new Produto(1, "Mouse xing ling", 10.90M);
Produto p2 = new Produto(2, "Teclado Multilaser", 20.90M);

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());
p1.setValor(29.90M);
p1.setDescricao("Mouse Razer");

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

Endereco e1 = new Endereco(1,
    "15906304",
    "Mario Miziara",
    "91",
    "Sobral",
    "Taquaritinga"
    );

Cliente c1 = new Cliente(1, "Fernando", "991340447", e1);
Cliente c2 = new Cliente(2, "Stéfani", "991340447", e1);
Cliente c3 = new Cliente(3, "Ana Gabriela", "991340447", e1);
Cliente c4 = new Cliente(4, "Isadora", "991340447", e1);
Cliente c5 = new Cliente(5, "Gileadi", "991340447", e1);

Console.WriteLine(c1.getEndereco().EnderecoCompleto());
c1.getEndereco().setRua("Prudente de Morais");
Console.WriteLine(c1.getEndereco().EnderecoCompleto());
c1.getEndereco().AtualizarEndereco("Julio de Morais", "585", "Portal Itamaracá");
Console.WriteLine(c1.getEndereco().EnderecoCompleto());

Carro car = new Carro();
car.cor = "Vermelho";
car.quantidadeRodas = 4;
car.quantidadeAssentos = 5;
car.temMotor = true;

Bike bicicleta = new Bike();
bicicleta.cor = "Rosa";
bicicleta.quantidadeRodas = 2;
bicicleta.quantidadeAssentos = 1;
bicicleta.temMotor = false;

Aviao aviao = new Aviao();
aviao.cor = "Branco";
aviao.quantidadeRodas = 18;
aviao.quantidadeAssentos = 176;
aviao.temMotor = true;

List<Veiculo> veiculoLista = new List<Veiculo>();
veiculoLista.Add(car);
veiculoLista.Add(bicicleta);
veiculoLista.Add(aviao);

foreach (var item in veiculoLista)
{
    Console.WriteLine(item.ExibirDados());
}

Console.WriteLine("Qtd de itens na lista: " + veiculoLista.Count);

//Crie duas listas
//Uma lista de Produtos com 400 produtos
//Outra lista de Clientes com 250 clientes

Random rand = new Random();

List<Produto> produtoLista = new List<Produto>();
for (int i = 0; i < rand.Next(200,500); i++)
{
    Produto p = new Produto(i, "Produto " + i, i/2*15);
    produtoLista.Add(p);
}

foreach (var item in produtoLista)
{
    Console.WriteLine(item.ExibeDadosProduto());
}

Console.WriteLine("Qtde de produtos na lista: " + produtoLista.Count);

List<Cliente> listaCliente = new List<Cliente>();
for (int i = 0; i < 250; i++)
{
    Endereco e = new Endereco(1, "Rua", "18701240", "1", " ", " ");
    Cliente c = new Cliente(i, "Nome " + i, "3331-5555", e);
    listaCliente.Add(c);
}

foreach (var item in listaCliente)
{
    Console.WriteLine(item.ExibeDadosCliente());
}

Console.WriteLine("Qtde de clientes na lista: " + listaCliente.Count);