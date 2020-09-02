using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 50f;
    private float  fireRate = 0.25f;
    private float rateOfFirePointer;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.Mouse0)&&Time.time>rateOfFirePointer) //used get key so the player can use full auto
        {
            rateOfFirePointer=Time.time+fireRate; //sets the rate of fire
            shoot();
        }
    }

    void shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        FindObjectOfType<AudioManager>().Play("bulletSound"); //whenever bullet is shot sound file is used
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
