using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropGarbage : MonoBehaviour {

    public GameObject garbage;

    void Update () {
        if(Input.GetMouseButtonDown(0)) {
            RaycastHit hitInfo;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out hitInfo))
            {
                Instantiate(garbage,hitInfo.point,Quaternion.identity);
            }
        }
    }
}
