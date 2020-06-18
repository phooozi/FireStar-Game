using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    public GameObject objectPrefab;
    public GameObject effects;
    public float minY, maxY, minX, maxX;
    public float randYPos, randXPos;

 

    // Start is called before the first frame update
    
    void Start()
    {
        //spawn a column
        SpawnObject();
        
    }
    
    public void SpawnObject()
    {
        float randXPos = Random.Range(minX, maxX);
        float randYPos = Random.Range(minY, maxY);
        GameObject newObject = Instantiate(objectPrefab);
        newObject.transform.position = new Vector2(randXPos, randYPos);
    }

    public void SpawnFireworks()
    {
        GameObject newObject1 = Instantiate(effects);
        newObject1.transform.position = new Vector2(randXPos, randYPos);
        Destroy(newObject1, 10f);
    }

}
