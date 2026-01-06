using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int Coins { get; private set; } = 0;
    

    public void LoseCoins(int amount)
    {
        Coins -= amount;
        if (Coins <= 0)
        {
            Coins = 0;
        }
    }
    
    public void GainCoins(int amount)
    {
        Coins += amount;
    }
    
}
