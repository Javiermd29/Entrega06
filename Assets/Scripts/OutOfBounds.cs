using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{

    [SerializeField] private float leftBound = -25f;
    [SerializeField] private float bottomBound = 1f;

    
    void Update()
    {

        if (transform.position.y < bottomBound)
        {
            Destroy(gameObject);
            Debug.Log("GAME OVER!");
            Time.timeScale = 0;
        }

        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }

    }
}
