using System;
using System.Collections.Generic;
using System.Globalization;

namespace TheatricalPlayersRefactoringKata;

public class ImpressoraFactura
{
    public string Imprimir(Factura factura, Dictionary<string, Obra> obres)
    {
        var importTotal = 0;
        var creditsVolum = 0;
        var resultat = string.Format("Factura per a {0}\n", factura.Client);
        var informacioCultural = new CultureInfo("ca-ES");

        foreach (var actuacio in factura.Actuacions)
        {
            var importActual = 0;

            var obra = obres[actuacio.IdObra];
            switch (obra.Tipus)
            {
                case "tragèdia":
                    importActual = 40000;
                    if (actuacio.Assistencia > 30)
                    {
                        importActual += 1000 * (actuacio.Assistencia - 30);
                    }
                    break;
                case "comèdia":
                    importActual = 30000;
                    if (actuacio.Assistencia > 20)
                    {
                        importActual += 10000 + 500 * (actuacio.Assistencia - 20);
                    }
                    importActual += 300 * actuacio.Assistencia;
                    break;
                default:
                    throw new Exception("tipus desconegut: " + obra.Tipus);
            }

            // afegeix crèdits per volum
            creditsVolum += Math.Max(actuacio.Assistencia - 30, 0);
            // afegeix crèdits extra per cada cinc assistents a una comèdia
            if (obra.Tipus == "comèdia")
            {
                creditsVolum += (int)Math.Floor((decimal)actuacio.Assistencia / 5);
            }

            // imprimeix la línia per a aquesta comanda
            resultat += String.Format(informacioCultural, "  {0}: {1:C} ({2} seients)\n", obra.Nom, Convert.ToDecimal(importActual / 100), actuacio.Assistencia);
            importTotal += importActual;
        }
        resultat += String.Format(informacioCultural, "L'import a pagar és {0:C}\n", Convert.ToDecimal(importTotal / 100));
        resultat += String.Format("Heu guanyat {0} crèdits\n", creditsVolum);
        return resultat;
    }
}
