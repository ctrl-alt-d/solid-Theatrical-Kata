using System.Collections.Generic;

namespace TheatricalPlayersRefactoringKata;

public class Factura(string client, List<Representacio> representacions)
{
    private string _client = client;
    private List<Representacio> _representacions = representacions;

    public string Client { get => _client; set => _client = value; }
    public List<Representacio> Representacions { get => _representacions; set => _representacions = value; }
}
