using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedSphere : MonoBehaviour {

    private static SpawnedSphere prefab
    {
        get { return Resources.Load<SpawnedSphere>("Prefabs/SpawnedSphere"); }
    }

    public static void CreateFromPrefab(Transform spawner)
    {
        SpawnedSphere sphere = Instantiate(prefab);
        sphere.transform.parent = GameObject.Find("Spheres").transform;

        sphere.transform.rotation = spawner.rotation;

        Vector3 position = spawner.position +
            (spawner.forward * GameValues.Spawners.spawnDistance);
        position.y = GameValues.Spawners.sphereRadius / 2;

        sphere.transform.position = position;
    }
}
