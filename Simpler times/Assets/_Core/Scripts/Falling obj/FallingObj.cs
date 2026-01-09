using UnityEngine;

public class FallingObj : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.GetComponent<PlayerStats>())
        {
            EventManager.OnGoodObjectCollect(); // test
            Destroy(gameObject);
        }
    }
}
