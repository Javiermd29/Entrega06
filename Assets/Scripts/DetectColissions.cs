using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectColissions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Dog"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

        
    }

}
