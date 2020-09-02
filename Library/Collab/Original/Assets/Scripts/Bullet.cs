using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
  RaycastHit2D hit;

  void OnCollisionEnter2D(Collision2D other)
  {
    if (other.collider.tag!=("Bullet")){
      if (other.gameObject.CompareTag("Enemy"))
      {
        Destroy(other.gameObject);
        InfoSystem.score += 100;
      }
      Destroy(this.gameObject);
    }
  }
}
