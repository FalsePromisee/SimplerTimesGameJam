using System.Collections;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    protected IEnumerator SpawnObject(GameObject objectToSpawn, float delayToSpawn)
    {
        while (true)
        {
            yield return new WaitForSeconds(delayToSpawn);
            int randomIndex = Random.Range(-7, 9);
            Vector2 positionToSpawn = new Vector2(randomIndex, transform.position.y);
            Instantiate(objectToSpawn, positionToSpawn, Quaternion.identity);
            
        }

    }

}
