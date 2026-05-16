using System.Collections.Generic;

namespace TheatricalPlayersRefactoringKata;

public class Factura(string client, List<Representacio> actuacions)
{
    private string _client = client;
    private List<Representacio> _actuacions = actuacions;

    public string Client { get => _client; set => _client = value; }
    public List<Representacio> Actuacions { get => _actuacions; set => _actuacions = value; }
}
