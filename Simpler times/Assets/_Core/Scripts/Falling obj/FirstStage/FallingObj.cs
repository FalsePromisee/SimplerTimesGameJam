using UnityEngine;

public class FallingObj : MonoBehaviour, ICollectable
{
    //scriptableobject 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.GetComponent<PlayerStats>())
        {
            Collect();
        }
        else if(GameManager.Instance.IsSecondStage)
        {
            Debug.Log("Second Stage, u lost points");
        }
    }

    public void Collect()
    {
        EventManager.OnGoodObjectCollect(2);
        Destroy(gameObject);
    }
}
