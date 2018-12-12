using System;

public class Palestra
{
    public string Nome { get; set; }
    public int Duracao { get; set; }
    
    public Palestra(string nome, int duracao)
	{
        Nome = nome;
        Duracao = duracao;
	}
}
