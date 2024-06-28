using UnityEngine;
using System.Collections;

public class Randomxd : MonoBehaviour
{
    public GameObject objectToSpawn; 
    public int numberOfObjectsToCreate = 5; 
    public float minTimeDiff = 1.0f; 
    public float maxTimeDiff = 5.0f; 
    public float spawnXRange = 10.0f; 
    public float spawnY = 5.0f; 

    void Start()
    {
        StartCoroutine(CreateObjectsAtRandom());
    }

    IEnumerator CreateObjectsAtRandom()
    {
        for (int i = 0; i < numberOfObjectsToCreate; i++)
        {
            
            float randomX = Random.Range(-spawnXRange / 2f, spawnXRange / 2f);

            
            Instantiate(objectToSpawn, new Vector3(randomX, spawnY, transform.position.z), Quaternion.identity);

            
            yield return new WaitForSeconds(Random.Range(minTimeDiff, maxTimeDiff));
        }
    }
}