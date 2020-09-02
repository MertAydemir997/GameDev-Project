using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    private Transform target;
    private bool seen;
    private Rigidbody2D rb;

    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 50f;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
      rb=this.GetComponent<Rigidbody2D>();
      seen = false;
      
    }

    // Update is called once per frame
    void Update()
    {
        

        if(seen == true)
        {
            // This part of the code makes the enemey face the player if they are in the enemies vision.
          Vector3 direction = target.position - transform.position;
          float angle = Mathf.Atan2(direction.y, direction.x)* Mathf.Rad2Deg;
          rb.rotation = angle;
          direction.Normalize();

          float distance = Vector2.Distance(transform.position, target.position);

            // Moves the enemy towards to player if the distance is greater than or equal to 9 units otherwise the enemy shoots at intervals of 1 second.
            if (distance >= 9)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
            else
            {
                time += Time.deltaTime;
                if (time >= 1)
                {
                    time = 0;
                    shoot();
                }
            }
        }
    }


    // When the player goes into the vision collider of the enemy the seen variable becomes true and the position of the player is recorded
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            seen = true;
            target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        }

    }

    // A method which creates bullet objects for the enemy when they are shooting.
    void shoot()
    {
        
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

    }


}
