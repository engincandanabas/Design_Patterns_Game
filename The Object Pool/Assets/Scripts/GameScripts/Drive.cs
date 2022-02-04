using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    public float speed = 10.0f;
    public GameObject bullet;
    void Update()
    {
        float translation = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        transform.Translate(translation, 0, 0);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Instantiate(bullet,this.transform.position,Quaternion.identity);
            GameObject gameObject= Pool.singleton.GetPooledObject("bullet");
            if(gameObject!=null)
            {
                gameObject.transform.position=this.transform.position;
                gameObject.SetActive(true);
            }
        }
    }
}