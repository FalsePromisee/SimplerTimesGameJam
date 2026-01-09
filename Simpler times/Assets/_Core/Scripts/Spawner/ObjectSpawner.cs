using System.Collections;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject objectToSpawn;

    private void Start()
    {
        StartCoroutine(SpawnObject());
    }

    private IEnumerator SpawnObject()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            int randomIndex = Random.Range(-7, 8);
            Vector2 positionToSpawn = new Vector2(randomIndex, transform.position.y);
            Instantiate(objectToSpawn, positionToSpawn, Quaternion.identity);


        }

    }

}
