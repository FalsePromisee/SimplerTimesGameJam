using UnityEngine;

public class BadObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent<PlayerStats>(out PlayerStats player))
        {
            player.LoseCoins(1);
            Debug.Log("Coint Amount: " + player.Coins);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
