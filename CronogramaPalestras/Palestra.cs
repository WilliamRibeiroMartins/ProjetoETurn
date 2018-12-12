using System;

public class Palestra
{
    private string _nome;
    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    private int _duracao;
    public int Duracao
    {
        get { return _duracao; }
        set { _duracao = value; }
    }
    
    public Palestra(string nome, int duracao)
	{
        Nome = nome;
        Duracao = duracao;
	}
}
