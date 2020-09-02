using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{

  void OnCollisionEnter2D(Collision2D other)
  {
    if (other.collider.tag!=("Bullet")){ //to stop bullets disappering in the barrell of the gun and stopping bullets from cancelling out
      if (other.gameObject.CompareTag("Enemy"))
      {
        FindObjectOfType<AudioManager>().Play("deathSound"); //play deathSound when bullet collides with enemy
        Destroy(other.gameObject); //destroy the enemies gameObject
        InfoSystem.score += 100; //this is classed as killing the enemy so 100 is added to the score
      }
      Destroy(this.gameObject);//allows bullet to be destroyed if it comes into contact with walls or furniture

    }
  }
}
