using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner {

    GameObject player;

    public ObjectSpawner(GameObject _player)
    {
        player = _player;
    }

    public void CheckAndHandleMouseClicks()
    {
        if (Input.GetMouseButtonUp(0))
        {
            SpawnCube();

        } else if(Input.GetMouseButtonUp(1))
        {
            SpawnSphere();
        }
    }


    public void SpawnCube()
    {
        SpawnedCube.CreateFromPrefab(player.transform);
    }

    public void SpawnSphere()
    {
        SpawnedSphere.CreateFromPrefab(player.transform);
    }
}
