using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Created by Robin Verleun on April 15, 2017
 * 
 * PlayerController logic.
 * Seperate from the MonoBehavior class to assist in testing
 * and code reusability.
 */

public class PlayerController {

    public float mouseSensitivity;
    public float cameraROM;

    float rotationY = 0.0f;


    GameObject player;
    Camera camera;

    public PlayerController(GameObject _player)
    {
        player = _player;
        camera = player.GetComponentInChildren<Camera>();
    }

    public void Translate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        player.transform.Translate(x, 0, z);
    }

    public void Rotate()
    {
        //Rotate the player left and right
        player.transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * mouseSensitivity);

        //Rotate the camera and clamp the motion
        rotationY += Input.GetAxis("Mouse Y") * mouseSensitivity;
        rotationY = Mathf.Clamp(rotationY, -1 * cameraROM, cameraROM);

        camera.transform.localEulerAngles = new Vector3(-rotationY, 0, 0);
    }

    public void MovePlayer()
    {
        Translate();
        Rotate();
    }
}
