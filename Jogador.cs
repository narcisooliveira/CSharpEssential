public class Jogador
{
    public int energia;
    public bool vivo;
    public string? nome;

    // Construtor com expression body
    public Jogador(bool vivo) => this.vivo = vivo;

    // Construtor vazio
    public Jogador() { }

    // Construtor padrão
    public Jogador(int energia, bool vivo, string nome) 
    {
        this.vivo = vivo;
        this.energia = energia;
        this.nome = nome;
        
    }

    // primeiro método
    public void chute()
    {
      Console.WriteLine($"{nome} está chutando");
    }

    // segundo método

    public void correr()
    {
      Console.WriteLine($"{nome} está correndo");
    }

    // terceiro método com argumentos

    public void passe(string nome2)
    {
      Console.WriteLine($"{nome} está passando para o jogador {nome2}");
    }
}
