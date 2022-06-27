using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingProjectile : MonoBehaviour
{

    [SerializeField] GameObject bullet;

    void Update()
    {
        Debug.Log(Input.GetAxis("Fire1"));
        //if ()
        //{
        //    Instantiate(bullet, transform.position, Quaternion.identity);
        //}
    }
}
