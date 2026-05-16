namespace TheatricalPlayersRefactoringKata;

public class Representacio(string idObra, int assistencia)
{
    private string _idObra = idObra;
    private int _assistencia = assistencia;

    public string IdObra { get => _idObra; set => _idObra = value; }
    public int Assistencia { get => _assistencia; set => _assistencia = value; }
}
