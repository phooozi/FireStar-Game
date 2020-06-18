using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDestroy : MonoBehaviour 
{
    float timer;
    float dieTime = 1.2f;
    private CountdownBar countDown;
    private GameManage spawnObject;
    public GameObject fireworksFX;



    // Start is called before the first frame update
    void Start()
    {
        countDown = GameObject.Find("CountdownTimer").GetComponent<CountdownBar>();
        spawnObject = GameObject.Find("RandomlySpawn").GetComponent<GameManage>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
        if (!countDown.isPaused)
        {
            timer += Time.deltaTime;
            if (timer >= dieTime)
            {
                if (gameObject.CompareTag("Button"))
                {


                    Destroy(gameObject);
                    timer = 0;
                    ScoreCounter.scoreValue -= 1;
                    if (ScoreCounter.scoreValue <= 0)
                    {
                        ScoreCounter.scoreValue = 0;
                    }
                    spawnObject.SpawnObject();

                }

            }
            
            else if (Input.GetMouseButtonDown(0))
            {
               
                if (hit.collider != gameObject.CompareTag("Button"))
                {
                    ScoreCounter.scoreValue -= 1;
                    if (ScoreCounter.scoreValue <= 0)
                    {
                        ScoreCounter.scoreValue = 0;
                    }
                    if (timer >= dieTime)
                    {
                        Destroy(gameObject);
                        timer = 0;
                        ScoreCounter.scoreValue -= 1;
                        if (ScoreCounter.scoreValue <= 0)
                        {
                            ScoreCounter.scoreValue = 0;
                        }
                        spawnObject.SpawnObject();
                    }
                }
                else if (hit.collider == gameObject.CompareTag("Button"))
                {
                    ScoreCounter.scoreValue += 1;
                    GameObject ob = Instantiate(fireworksFX);
                    ob.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
                    Destroy(ob, 10f);
                    Destroy(gameObject);
                    spawnObject.SpawnObject();
                    
                }
            }
        }



    }

    


}
