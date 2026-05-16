namespace TheatricalPlayersRefactoringKata;

public class Obra(string nom, string tipus)
{
    private string _nom = nom;
    private string _tipus = tipus;

    public string Nom { get => _nom; set => _nom = value; }
    public string Tipus { get => _tipus; set => _tipus = value; }
}
