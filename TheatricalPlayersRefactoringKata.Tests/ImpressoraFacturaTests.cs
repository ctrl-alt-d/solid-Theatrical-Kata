using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VerifyXunit;
using Xunit;

namespace TheatricalPlayersRefactoringKata.Tests;

public class ImpressoraFacturaTests
{
    [Fact]
    public Task Prova_exemple_factura()
    {
        var obres = new Dictionary<string, Obra>
        {
            { "terra-baixa", new Obra("Terra baixa", "tragèdia") },
            { "pel-davant-i-pel-darrere", new Obra("Pel davant i pel darrere", "comèdia") },
            { "mar-i-cel", new Obra("Mar i cel", "tragèdia") }
        };

        var factura = new Factura(
            client: "BigCo", 
            actuacions: [
                new Representacio("terra-baixa", 55),
                new Representacio("pel-davant-i-pel-darrere", 35),
                new Representacio("mar-i-cel", 40)
            ]);

        var impressoraFactura = new ImpressoraFactura();
        var resultat = impressoraFactura.Imprimir(factura, obres);

        return Verifier.Verify(resultat);
    }
    [Fact]
    public void Prova_factura_amb_tipus_d_obra_nous()
    {
        var obres = new Dictionary<string, Obra>
        {
            { "el-cafe-de-la-marina", new Obra("El cafè de la Marina", "costumista") },
            { "maria-rosa", new Obra("Maria Rosa", "drama") }
        };

        var factura = new Factura(
            client: "BigCoII",
            actuacions: [
                new Representacio("el-cafe-de-la-marina", 53),
                new Representacio("maria-rosa", 55)
            ]
        );

        var impressoraFactura = new ImpressoraFactura();

        Assert.Throws<Exception>(() => impressoraFactura.Imprimir(factura, obres));
    }
}
