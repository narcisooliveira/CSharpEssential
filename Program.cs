Console.WriteLine("## Classes e Métodos ##");

Jogador jogador = new Jogador();

jogador.energia = 100;
jogador.vivo = true;
jogador.nome = "Bruno";

Console.WriteLine($"Nome do jogador: {jogador.nome}");
Console.WriteLine($"Energia do jogador: {jogador.energia}");
Console.WriteLine($"Status do jogador: {jogador.vivo}");

// Alocação de memória

// Instanciação de um objeto com o mesmo local na memória de outro objeto.
Jogador jogador2 = jogador;

Console.WriteLine("Exibindo valores do segundo objeto");
Console.WriteLine($"Nome do jogador: {jogador2.nome}");
Console.WriteLine($"Energia do jogador: {jogador2.energia}");
Console.WriteLine($"Status do jogador: {jogador2.vivo}");

// Instaciando um novo objeto de maneiras diferentes

var jogador3 = new Jogador();

jogador3.energia = 50;
jogador3.vivo = true;
jogador3.nome = "Lucas";

Jogador jogador4 = new()
{
  energia = 50,
  vivo = false,
  nome = "João"
};

Console.WriteLine("Exibindo valores do terceiro objeto");
Console.WriteLine($"Nome do jogador: {jogador3.nome}");
Console.WriteLine($"Energia do jogador: {jogador3.energia}");
Console.WriteLine($"Status do jogador: {jogador3.vivo}");


// Métodos

jogador.chute();

jogador2.correr();

jogador3.passe(jogador4.nome);

Console.ReadLine();