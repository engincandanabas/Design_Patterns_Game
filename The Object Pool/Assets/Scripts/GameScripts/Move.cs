using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 velocity;
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(velocity);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("asteroid"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
