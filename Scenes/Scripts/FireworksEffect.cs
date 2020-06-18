using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworksEffect : MonoBehaviour
{
    public GameObject fireworksFX;
    public void Click()
    {
        GameObject ob = Instantiate(fireworksFX);
        Destroy(ob, 1.7f);
    }
}
