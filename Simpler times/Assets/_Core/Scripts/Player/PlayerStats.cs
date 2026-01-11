using System;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int Coins { get; private set; } = 0;
    
    
    private void GainCoins(int amount)
    {
        Coins += amount;
    }
    

    public void LoseCoins(int amount)
    {
        Coins -= amount;
        if (Coins <= 0)
        {
            Coins = 0;
        }
    }
    



    // Events ----------

    private void OnEnable()
    {
        EventManager.OnGoodObjectCollected += CollectedGoodObject;
        EventManager.OnBadObjectCollected += CollectedBadObject;
    }
    private void OnDisable()
    {
        EventManager.OnGoodObjectCollected -= CollectedGoodObject;
        EventManager.OnBadObjectCollected -= CollectedBadObject;
    }

    private void CollectedBadObject(int amount)
    {
        LoseCoins(amount);
        Debug.Log("Coins amount: " + Coins);
    }

    private void CollectedGoodObject(int  amount)
    {
        GainCoins(amount);
        Debug.Log("Coins amount: " + Coins);
    }
}
