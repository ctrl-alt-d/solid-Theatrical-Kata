using System;
using System.Collections.Generic;
using System.Globalization;

namespace TheatricalPlayersRefactoringKata;

public class ImpressoraFactura(Dictionary<string, Obra> obres)
{
    private readonly Dictionary<string, Obra> _obres = obres;

    public string Imprimir(Factura factura)
    {
        var importTotal = 0;
        var puntsFidelitzacio = 0;
        var resultat = $"Factura per a {factura.Client}\n";
        CultureInfo informacioCultural = new("ca-ES");

        foreach (var repre in factura.Representacions)
        {
            var importRepresentacio = 0;

            var obra = _obres[repre.IdObra];
            switch (obra.Tipus)
            {
                case "tragèdia":
                    importRepresentacio = 40000;
                    if (repre.Assistencia > 30)
                    {
                        importRepresentacio += 1000 * (repre.Assistencia - 30);
                    }
                    break;
                case "comèdia":
                    importRepresentacio = 30000;
                    if (repre.Assistencia > 20)
                    {
                        importRepresentacio += 10000 + 500 * (repre.Assistencia - 20);
                    }
                    importRepresentacio += 300 * repre.Assistencia;
                    break;
                default:
                    throw new Exception("tipus desconegut: " + obra.Tipus);
            }

            // afegeix punts de fidelització
            puntsFidelitzacio += Math.Max(repre.Assistencia - 30, 0);
            // afegeix punts de fidelització extra per cada cinc assistents a una comèdia
            if (obra.Tipus == "comèdia")
            {
                puntsFidelitzacio += repre.Assistencia / 5;
            }

            // imprimeix la línia per a aquesta comanda
            resultat += $"  {obra.Nom}: {(importRepresentacio / 100m).ToString("C", informacioCultural)} ({repre.Assistencia} seients)\n";
            importTotal += importRepresentacio;
        }
        resultat += $"L'import a pagar és {(importTotal / 100m).ToString("C", informacioCultural)}\n";
        resultat += $"Heu guanyat {puntsFidelitzacio} punts de fidelització\n";
        return resultat;
    }
}
