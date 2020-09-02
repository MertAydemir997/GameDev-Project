using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;
    public float zoom;
    private Vector3 Pos;

    void Start()
    {
       
    }

    void LateUpdate()
    {
        //Get's the position of the player and moves the camera directly above the player. As the player moves so does the camera
        Pos = new Vector3(Player.transform.position.x, Player.transform.position.y, zoom);
        transform.position = Pos;
    }
}
