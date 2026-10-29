namespace Poker.Test;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void CriarMao()
    {
        Mao mao = new Mao("2O");

        Assert.AreEqual("2O", mao.card1);
    }
}
