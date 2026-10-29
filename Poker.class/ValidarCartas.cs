namespace Poker;

public static class ValidarCartas
{

    public static bool ValidarMao(Mao mao1, Mao mao2)
    {
        if (mao1.card1 > mao2.card1)
        {
          return true;  
        }

        return false;
    }

}
