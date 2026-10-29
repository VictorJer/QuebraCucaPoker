namespace Poker.Test;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void CriarMao()
    {
        Mao mao = new Mao("2O");

        Assert.AreEqual(2, mao.card1);
    }

    [TestMethod]
    public void MaoUmMaiorQueMaoDois()
    {
        Mao mao1 = new Mao("9O");
        Mao mao2 = new Mao("2O");

        var resultado = Vencedor.ValiarPesoCartas(mao1, mao2);

        Assert.AreEqual(ResultadoVencedor.Mao1, resultado);
    }

    [TestMethod]
    public void QuemGanhaDuasCartas()
    {
        Mao mao1 = new Mao("9O", "9O");
        Mao mao2 = new Mao("2O", "2O");

        var resultado = Vencedor.ValiarPesoCartas(mao1, mao2);

        Assert.AreEqual(ResultadoVencedor.Mao1, resultado);
    }

    [TestMethod]
    public void MaoDoisGanhaDuasCartas()
    {
        Mao mao1 = new Mao("2O", "2O");
        Mao mao2 = new Mao("9O", "9O");

        var resultado = Vencedor.ValiarPesoCartas(mao1, mao2);

        Assert.AreEqual(ResultadoVencedor.Mao2, resultado);
    }

    [TestMethod]
    public void MaoEmpataComDuasCartas()
    {
        Mao mao1 = new Mao("9O", "2O");
        Mao mao2 = new Mao("5O", "6O");

        var resultado = Vencedor.ValiarPesoCartas(mao1, mao2);

        Assert.AreEqual(ResultadoVencedor.Empate, resultado);
    }
}
