using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;

    public static int currLevel;


    void Start()
    {

        currLevel = SceneManager.GetActiveScene().buildIndex;
    }

   
    void FixedUpdate()
    {
        //These 5 lines handle the horizontal and vertical movement of the player via key input.
        float Horizontal = Input.GetAxisRaw("Horizontal");
        float Vertical = Input.GetAxisRaw("Vertical");
        float dh = speed * Horizontal * Time.deltaTime;
        float dv = speed * Vertical * Time.deltaTime;
        transform.position = new Vector2(transform.position.x + dh, transform.position.y + dv);

        //This part allows the player to face in the direction where the mouse pointer is.
        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(dir.y, dir.x)* Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

    }

    //When a player collides with a bullet object the player dies so the scene changes to the GameOver scene. We do this using an OnCollision Method.
    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Bullet"))
        {
            currLevel = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(7);
        }
        
    }
}
