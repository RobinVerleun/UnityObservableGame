using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedCube : MonoBehaviour {

	private static SpawnedCube prefab
    {
        get { return Resources.Load<SpawnedCube>("Prefabs/SpawnedCube"); }
    }

    public static void CreateFromPrefab(Transform spawner)
    {
        SpawnedCube cube = Instantiate(prefab);
        cube.transform.parent = GameObject.Find("Cubes").transform;

        cube.transform.rotation = spawner.rotation;

        Vector3 position = spawner.position +
            (spawner.forward * GameValues.Spawners.spawnDistance);
        position.y = GameValues.Spawners.cubeHeight / 2;

        cube.transform.position = position;
    }
}
