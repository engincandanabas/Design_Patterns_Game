using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInvis : MonoBehaviour
{
    private void OnBecameInvisible() {
        // Destroy(this.gameObject);
        this.gameObject.SetActive(false);
    }
}
