using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject asteroid;
    void Update()
    {
        if(Random.Range(0,100)<5)
        {
            GameObject gameObject=Pool.singleton.GetPooledObject("asteroid");
            if(gameObject!=null)
            {
                gameObject.transform.position=this.transform.position+new Vector3(Random.Range(-10,10),0,0);
                gameObject.SetActive(true);
            }
        }
    }
}
