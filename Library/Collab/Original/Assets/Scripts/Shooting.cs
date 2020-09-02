using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 50f;
    private float  fireRate = 0.1f;
    private float rateOfFirePointer;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.Mouse0)&&Time.time>rateOfFirePointer)
        {
            rateOfFirePointer=Time.time+fireRate;
            shoot();
        }
    }

    void shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
