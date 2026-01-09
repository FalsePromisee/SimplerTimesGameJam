using System;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int Coins { get; private set; } = 0;
    public int CollectedObjects { get; private set; } = 0;
    
    public void GainCoins(int amount)
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

    public void CollectedObject()
    {
        CollectedObjects++;
    }



    // Events ----------

    private void OnEnable()
    {
        EventManager.OnBadObjectCollected += CollectedGoodObject;
    }
    private void OnDisable()
    {
        EventManager.OnBadObjectCollected -= CollectedGoodObject;
    }

    private void CollectedGoodObject()
    {
        GainCoins(1);
        Debug.Log("Coins amount: " + Coins);
    }
}
