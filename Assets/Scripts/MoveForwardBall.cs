using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardBall : MonoBehaviour
{
    [SerializeField] private float speed;

    void Update()
    {

        transform.Translate(Vector3.down * speed * Time.deltaTime);

    }
}
