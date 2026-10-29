namespace Poker;

public static class Vencedor
{
    public static ResultadoVencedor Determinar(Mao mao1, Mao mao2)
    {


        int valorMao1 = mao1.card1 + (mao1.card2 ?? 0);
        int valorMao2 = mao2.card1 + (mao2.card2 ?? 0);

        if (valorMao1 > valorMao2)
        {
            return ResultadoVencedor.Mao1;
        }

        if (valorMao2 > valorMao1)
        {
            return ResultadoVencedor.Mao2;
        }

        return ResultadoVencedor.Empate;
    }

    public static ResultadoVencedor ValiarPesoCartas(Mao mao1, Mao mao2)
    {
        int valorMaoUm = mao1.card1
            + (mao1.card2 ?? 0)
            + (mao1.card3 ?? 0)
            + (mao1.card4 ?? 0)
            + (mao1.card5 ?? 0);
        int valorMaoDois = mao2.card1
            + (mao2.card2 ?? 0)
            + (mao2.card3 ?? 0)
            + (mao2.card4 ?? 0)
            + (mao2.card5 ?? 0);

        if (valorMaoUm > valorMaoDois)
        {
          return ResultadoVencedor.Mao1;  
        }

        if (valorMaoUm < valorMaoDois)
        {
            return ResultadoVencedor.Mao2;
        }

        return ResultadoVencedor.Empate;
    }
}