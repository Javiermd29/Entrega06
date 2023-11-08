using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootDog : MonoBehaviour
{
    [SerializeField] private GameObject dogPrefab;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            Debug.Log("Hola");
            shootDog();
        }

    }

    private void shootDog()
    {
        Instantiate(dogPrefab, transform.position, Quaternion.Euler(0, -90, 0));
    }

}
