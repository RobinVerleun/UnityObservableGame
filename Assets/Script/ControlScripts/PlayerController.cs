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

    public float mouseSensitivity = 5f;
    public float updownRange = 50.0f;


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
        Vector2 mouseDeltas = new Vector2(
            Input.GetAxis("Mouse X") * mouseSensitivity,
            Input.GetAxis("Mouse Y") * mouseSensitivity);

        player.transform.Rotate(Vector3.up, mouseDeltas.x);
        camera.transform.Rotate(Vector3.left, mouseDeltas.y);
        //ClampCamera();
    }

    //Don't like this one. Seems poorly done. TODO: Fix, currently broken
    public void ClampCamera()
    {
        Vector3 angles = camera.transform.localRotation.eulerAngles;
        if(angles.x > 40)
        {

            angles.x = 40;
        } else if(angles.x - 360 < -40)
        {

            angles.x = 320;
        }
        camera.transform.localRotation = Quaternion.Euler(angles);
    }

    public void MovePlayer()
    {
        Translate();
        Rotate();
    }
}
