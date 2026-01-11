using UnityEngine;

public class BadObject : MonoBehaviour, ICollectable
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.GetComponent<PlayerStats>())
        {
            Collect();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Collect()
    {
        EventManager.OnBadObjectCollect(1);
        Destroy(gameObject);
    }
}
